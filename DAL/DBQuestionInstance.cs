using BLL.ViewModel;
using BLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL
{
    public class DBQuestionInstance
    {
        private Repository<QuestionInstance> repository = new Repository<QuestionInstance>();
        /// <summary>
        /// Returns a list of QuestionViewModels with a ViewModel for each question in the open Quiz.
        /// OBS! The quiz MUST be confirmed to be open before this method i run.
        /// </summary>
        /// <param name="contestantId">The relevant contestant</param>
        /// <param name="quizId">The quiz that is open and the contestant is part of</param>
        public List<QuestionViewModel> SeeQuestionsOnQuiz(Guid contestantId, int quizInstanceId)
        {
            List<QuestionViewModel> models = new List<QuestionViewModel>();
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(repository.ConnectionString))
                {
                    // Opening the connection automatically enlists it in the 
                    // TransactionScope as a lightweight transaction.
                    connection.Open();

                    // Create the SqlCommand object and execute the first command.
                    var command = connection.CreateCommand();
                    command.CommandText = @"SELECT Header, [TimeOut], CorrectAnswer, 
                    ContestantId, QuestionInstance.QuestionId FROM QuestionInstance
                    LEFT JOIN (SELECT * FROM ContestantQuestionInstance WHERE 
                    ContestantID=@ContestantId) AS wrongAnswers ON 
                    QuestionInstance.QuestionId = wrongAnswers.QuestionId
                    WHERE QuestionInstance.QuizInstanceId=@QuizInstanceId";

                    command.Parameters.AddWithValue("@ContestantId", contestantId);
                    command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        models.Add(QuestionViewModelBuilder(reader, contestantId));
                    }
                }
                // The Complete method commits the transaction. If an exception has been thrown,
                // Complete is not  called and the transaction is rolled back.
                scope.Complete();
            }
            return models;
        }

        /// <summary>
        /// Returns a list of QuestionViewModels with a ViewModel for each question in the open Quiz.
        /// OBS! The quiz MUST be confirmed to be open before this method i run.
        /// </summary>
        /// <param name="contestantId">The relevant contestant</param>
        /// <param name="quizId">The quiz that is open and the contestant is part of</param>
        public bool CanContestantAnswerQuestion(Guid contestantId, int quizInstanceId, int questionId)
        {
            System.IO.StringWriter writer = new System.IO.StringWriter();
            QuestionViewModel model = new QuestionViewModel();
            using (TransactionScope scope = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(repository.ConnectionString))
                {
                    // Opening the connection automatically enlists it in the 
                    // TransactionScope as a lightweight transaction.
                    connection.Open();

                    // Create the SqlCommand object and execute the first command.
                    var command = connection.CreateCommand();
                    command.CommandText = @"SELECT Header, [TimeOut], CorrectAnswer, 
                    ContestantId, QuestionInstance.QuestionId FROM QuestionInstance
                    LEFT JOIN (SELECT * FROM ContestantQuestionInstance WHERE 
                    ContestantID=@ContestantId) AS wrongAnswers ON 
                    QuestionInstance.QuestionId = wrongAnswers.QuestionId
                    WHERE QuestionInstance.QuizInstanceId=@QuizInstanceId AND 
                    QuestionInstance.QuestionId=@QuestionId";
                    command.Parameters.AddWithValue("@ContestantId", contestantId);
                    command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);
                    command.Parameters.AddWithValue("@QuestionId", questionId);
                    SqlDataReader reader = command.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        model = QuestionViewModelBuilder(reader, contestantId);
                    }
                }
                // The Complete method commits the transaction. If an exception has been thrown,
                // Complete is not  called and the transaction is rolled back.
                scope.Complete();
            }
            if (model.State == State.OPEN)
            {
                // Will be reset by the answer set to null method later in the controller
                //SetQuestionInstanceTimeOut(quizInstanceId, questionId, DateTime.Now.AddSeconds(32));
                return true;
            }
            return false;
        }

        internal List<QuestionInstance> GetQuestionInstances(int quizInstanceId)
        {
            var command = new SqlCommand();
            command.CommandText = @"SELECT * FROM QuestionInstance
                                    WHERE QuizInstanceId=@QuizInstanceId";
            command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);

            DBContestant dbContestant = new DBContestant();
            List<QuestionInstance> questionInstances = repository.MultiRead(command);

            foreach (QuestionInstance obj in questionInstances)
            {
                obj.CorrectAnswer = dbContestant.GetContestant(quizInstanceId, obj.QuestionId);
                obj.WrongAnswers = dbContestant.GetContestants(obj.QuizInstanceId, obj.QuestionId);
            }
            return questionInstances;
        }

        /// <summary>
        /// Sets a time stamp on a QuestionInstance
        /// </summary>
        /// <param name="quizInstance">The instance, that is to be closed</param>
        public void SetQuestionInstanceTimeOut(int quizInstanceId, int questionId, DateTime time)
        {
            var command = new SqlCommand();
            command.CommandText = @"UPDATE QuestionInstance SET TimeOut = @time
                                        WHERE QuizInstanceId = @quizInstanceId AND QuestionId = @questionId";

            command.Parameters.AddWithValue("@time", time);
            command.Parameters.AddWithValue("@quizInstanceId", quizInstanceId);
            command.Parameters.AddWithValue("@questionId", questionId);

            repository.ExecuteStatement(command);
        }

        /// <summary>
        /// Builds single QuestionViewModel based on a reader.
        /// It calculates the state of the ViewModel here.
        /// </summary>
        private QuestionViewModel QuestionViewModelBuilder(SqlDataReader reader, Guid contestantId)
        {
            QuestionViewModel model = new QuestionViewModel();

            model.Header = reader["Header"].ToString();
            model.QuestionId = Convert.ToInt32(reader["QuestionId"].ToString());

            Guid guid; //A Guid can't be null
            //If the question has been answered, save the guid
            if (Guid.TryParse(reader["CorrectAnswer"].ToString(), out guid))
            {
                //Is the guid someone else?
                if (!guid.Equals(contestantId))
                {
                    model.SetState(State.LOCKED);
                }
                //or is it this contestant?
                else
                {
                    model.SetState(State.CORRECT);
                }
            }
            //Has this contestant tried this question and answered with a wrong question?
            else if (Guid.TryParse(reader["ContestantId"].ToString(), out guid))
            {
                model.SetState(State.WRONG);
            }
            //Has the timeout been passed yet?
            else if (Convert.ToDateTime(reader["TimeOut"].ToString()).Ticks > DateTime.Now.Ticks)
            {
                model.SetState(State.PENDING);
            }
            //If none of all that is the case, the question is open
            else
            {
                model.SetState(State.OPEN);
            }
            return model;
        }

        /// <summary>
        /// Used in the performance test for QuestionViewModel
        /// </summary>
        /// <param name="contestantId"></param>
        /// <param name="quizInstanceId"></param>
        /// <returns></returns>
        public List<QuestionInstance> GetQuestionInstances(int quizInstanceId, Guid contestantId)
        {
            List<QuestionInstance> questionInstances = new List<QuestionInstance>();

            var command = new SqlCommand();
            command.CommandText = @"SELECT * FROM QuestionInstance
                                    WHERE QuizInstanceId=@QuizInstanceId";
            command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);

            QuestionInstance questionInstance = new QuestionInstance();
            DBContestant dbContestant = new DBContestant();

            foreach (QuestionInstance obj in repository.MultiRead(command))
            {
                questionInstance.CorrectAnswer = dbContestant.GetContestant(quizInstanceId, questionInstance.QuestionId);
                questionInstance.WrongAnswers = dbContestant.GetContestants(questionInstance.QuizInstanceId, questionInstance.QuestionId);
                questionInstances.Add(questionInstance);
            }
            return questionInstances;
        }
    }
}
