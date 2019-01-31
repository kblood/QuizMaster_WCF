using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Model;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace DAL
{
    public class DBQuizInstance
    {
        private Repository<QuizInstance> repository = new Repository<QuizInstance>();
        /// <summary>
        /// Opens a QuizInstance of a quiz and returns it
        /// </summary>
        /// <param name="quiz">The Quiz that is to be opened</param>
        /// <param name="user">The User who opens it</param>
        internal QuizInstance OpenQuiz(Quiz quiz, User user)
        {
            QuizInstance quizInstance = new QuizInstance();
            quizInstance.Owner = user;
            quizInstance.Quiz = quiz;
            quizInstance.StartDate = DateTime.Now;
            quizInstance.Open = true;
            quizInstance.Running = false;


            var command = new SqlCommand();
            command.CommandText = @"INSERT INTO QuizInstance(UserId, QuizId, StartDate, [Open], Running) " +
                                "VALUES (@userId, @quizId, @startDate, @open, @running); Select Scope_Identity()";

            command.Parameters.AddWithValue("@userId", user.Id);
            command.Parameters.AddWithValue("@quizId", quiz.Id);
            command.Parameters.AddWithValue("@startDate", quizInstance.StartDate);
            command.Parameters.AddWithValue("@open", quizInstance.Open);
            command.Parameters.AddWithValue("@running", quizInstance.Running);

            quizInstance.Id = repository.ExecuteStatement(command);

            //If an error occurs, return null instead
            if (quizInstance.Id == 0)
            {
                quizInstance = null;
            }

            return quizInstance;
        }

        public bool GetQuizRunningByContestantId(Guid contestantId)
        {
            bool running = false;
            var command = new SqlCommand();
            command.CommandText = @"SELECT Running FROM QuizInstance WHERE Id = (SELECT QuizInstanceId FROM Contestant WHERE Id = @id)";
            command.Parameters.AddWithValue("@id", contestantId);

            running = Convert.ToBoolean(repository.SimpleRead(command).ToString());
            return running;
        }

        /// <summary>
        /// Closes a quiz, so that it no longer is possible to add more contestants
        /// </summary>
        /// <param name="quizInstance">The instance, that is to be closed</param>
        internal void CloseQuiz(QuizInstance quizInstance)
        {
            var command = new SqlCommand();
            command.CommandText = @"UPDATE QuizInstance SET [Open] = @open WHERE Id = @id";

            command.Parameters.AddWithValue("@id", quizInstance.Id);
            command.Parameters.AddWithValue("@open", false);

            repository.ExecuteStatement(command);
        }

        /// <summary>
        /// Sets whether the QuizInstance is running or not
        /// </summary>
        /// <param name="quizInstance">QuizInstance that is to be changed. Only the "running" and "id" attributes are used</param>
        internal void RunQuiz(QuizInstance quizInstance)
        {
            var command = new SqlCommand();
            command.CommandText = @"UPDATE QuizInstance SET Running = @running WHERE Id = @id";

            command.Parameters.AddWithValue("@id", quizInstance.Id);
            command.Parameters.AddWithValue("@running", quizInstance.Running);
            //command.ExecuteNonQuery();

            using (TransactionScope scope = new TransactionScope())
            {
                if(repository.ExecuteStatement(command) < 1)
                {
                    scope.Dispose();
                    return;
                }
                if (quizInstance.Running)
                {
                    if(new DBQuestion().CreateQuestionInstances(quizInstance.Id) < 1)
                    {
                        scope.Complete();
                    }
                }
                scope.Complete();
            }
        }

        internal QuizInstance GetQuizInstanceByUserId(int userId)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "WHERE UserId = "+userId+" AND [Open] = 1";
            //command.Parameters.AddWithValue("@userId", userId);
            return GetQuiz(command);
        }

        public QuizInstance GetQuizInstanceById(int quizInstanceId, bool includeAll)
        {
            QuizInstance quizInstance = new QuizInstance();
            SqlCommand command = new SqlCommand();
            command.CommandText = "WHERE Id = " + quizInstanceId;
            quizInstance = GetQuiz(command);
            if(includeAll)
            {
                quizInstance.QuestionInstances = new DBQuestionInstance().GetQuestionInstances(quizInstanceId);
                quizInstance.Contestants = new DBContestant().GetContestants(quizInstanceId);
            }
            return quizInstance;
        }

        public List<QuizInstance> GetQuizInstancesByUserId(int userId)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM QuizInstance WHERE UserId = @userId";
            command.Parameters.AddWithValue("@userId", userId);
            List<QuizInstance> quizInstances = repository.MultiRead(command);
            foreach(QuizInstance quizInstance in quizInstances)
            {
                quizInstance.Quiz = new DBQuiz().GetQuizById(quizInstance.QuizId);
            }

            return quizInstances;
        }

        private QuizInstance GetQuiz(SqlCommand command)
        {
            QuizInstance quizInstance = new QuizInstance();
            command.CommandText = @"SELECT * FROM QuizInstance " + command.CommandText;
            quizInstance = repository.SingleRead(command);
            if(quizInstance == null)
            {
                return null;
            }
            quizInstance.Quiz = new DBQuiz().GetQuizById(quizInstance.QuizId);
            return quizInstance;
        }

        /// <summary>
        /// Checks whether a quizInstance is running by quizInstance id
        /// </summary>
        /// <param name="quizInstanceId">The ID of the QuizInstance</param>
        public bool GetQuizRunningById(int quizInstanceId)
        {
            bool running = false;
            var command = new SqlCommand();
            command.CommandText = @"SELECT Running FROM QuizInstance WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", quizInstanceId);

            running = Convert.ToBoolean(repository.SimpleRead(command).ToString());
            return running;
        }

        /// <summary>
        /// Checks if An Active quiz is open or running
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public QuizInstance GetActiveQuizInstance(int userId)
        {
            QuizInstance quizInstance = new QuizInstance();
            SqlCommand command = new SqlCommand();
            command.CommandText = @"WHERE UserId = "+userId+" AND ([Open] = 1 OR Running = 1)";
            command.Parameters.AddWithValue("@userId", userId);
            quizInstance = GetQuiz(command);
            return quizInstance;
        }

    }
}
