using BLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAL
{
    public class DBQuestion
    {
        Repository<Question> repository = new Repository<Question>();

        /// <summary>
        /// Saves a Question in the DB. Passes attached Answers along to DBAnswer.
        /// DBAnswer returns the id for the correct Answer. Finaly, Question is updated with correct AnswerId.
        /// The Connection is created here, and the Transaction handled here, not in DBAnswer.
        /// </summary>
        /// <param name="question">The question that is to be inserted</param>
        public void SaveQuestion(Question question)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = @"INSERT INTO Question(Header, Text, CreateDate) VALUES (@Header, @Text, @CreateDate); Select Scope_Identity()";

                command.Parameters.AddWithValue("@Header", question.Header);
                command.Parameters.AddWithValue("@Text", question.Text);
                command.Parameters.AddWithValue("@CreateDate", question.CreateDate);

                //Returns Id for the newly inserted Question
                question.Id = repository.ExecuteStatement(command);
                if(question.Id < 1)
                {
                    scope.Dispose();
                    return;
                }
                //Save the answers on the question
                int correctAnswerId = new DBAnswer().SaveAnswers(question);
                if(correctAnswerId < 1)
                {
                    scope.Dispose();
                    return;
                }
                command.Dispose();

                //update Question is updated with CorrectAnswerId
                command.CommandText = @"UPDATE Question SET [CorrectAnswer] = @CorrectAnswer WHERE Id = @id";

                command.Parameters.AddWithValue("@id", question.Id);
                command.Parameters.AddWithValue("@CorrectAnswer", correctAnswerId);

                if(repository.ExecuteStatement(command)<1)
                {
                    scope.Dispose();
                }

                scope.Complete();
            }
        }

        /// <summary>
        /// Sets a Contestant to have given the correct answer to a question
        /// </summary>
        /// <param name="contestant">The contestant, who gave the answer</param>
        /// <param name="question">The question that the answer is to</param>
        public void AnsweredCorrectly(int quizInstanceId, Guid contestantId, int questionId)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = @"UPDATE QuestionInstance SET CorrectAnswer = @contestantId
                        WHERE QuizInstanceId = @quizInstanceId AND QuestionId = @questionId;
                        DELETE FROM ContestantQuestionInstance WHERE quizInstanceId=@quizInstanceId
                        AND contestantId=@contestantId AND questionId=@questionId";

            command.Parameters.AddWithValue("@contestantId", contestantId);
            command.Parameters.AddWithValue("@quizInstanceId", quizInstanceId);
            command.Parameters.AddWithValue("@questionId", questionId);

            repository.ExecuteStatement(command);
        }

        /// <summary>
        /// Extracts a Question with it's Answers from the database
        /// </summary>
        /// <param name="questionId">The Id of the question</param>
        public Question GetQuestionWithAnswers(int questionId)
        {
            Question question = new Question();
            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Question WHERE Id = @id";
            command.Parameters.AddWithValue("@id", questionId);

            question = repository.SingleRead(command);
            if(question.Id == 0)
            {
                return null;
            }
            question.Answers = new DBAnswer().GetAnswers(questionId);

            return question;
        }

        /// <summary>
        /// Sets a Contestant to have given the wrong answer to a question.
        /// Also resets the timeout on the QuizInstance.
        /// </summary>
        /// <param name="contestant">The contestant, who gave the answer</param>
        /// <param name="question">The question that the answer is to</param>
        /// <param name="answer">The answer that was given (may be null in case of timeout)</param>
        public void AnsweredWrong(int quizInstanceId, Guid contestantId, int questionId, int? answerId)
        {
            //string answer = answerId == null || answerId == 0 ? "" : ", " + answerId;
            //string insertAnswer = answer == "" ? "" : ", answerId";
            //string commandText = @"DELETE ContestantQuestionInstance
            //            WHERE quizInstanceId = "+quizInstanceId+" AND QuestionId = "+questionId+
            //            " AND ContestantId = '"+contestantId+@"'; INSERT INTO 
            //            ContestantQuestionInstance(quizInstanceId, questionId, contestantId"+insertAnswer+@")
            //            VALUES ("+quizInstanceId+ ", "+questionId+ ", '"+contestantId+"'"+ answer + @");
            //            UPDATE QuestionInstance SET [TimeOut] = '"+
            //            DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss")+@"' WHERE
            //            QuestionId="+questionId+" AND QuizInstanceId="+quizInstanceId+";";

            using (TransactionScope scope = new TransactionScope())
            {
                SqlCommand command = new SqlCommand();

                command.CommandText = @"DELETE ContestantQuestionInstance
                            WHERE quizInstanceId = @quizInstanceId AND QuestionId = @questionId
                            AND ContestantId = @contestantId;
                            INSERT INTO ContestantQuestionInstance(quizInstanceId, questionId, contestantId, answerId)
                            VALUES (@quizInstanceId, @questionId, @contestantId, @answerId);
                            UPDATE QuestionInstance SET TimeOut = @now WHERE
                            QuestionId=@questionId AND QuizInstanceId=@quizInstanceId;";

                command.Parameters.AddWithValue("@quizInstanceId", quizInstanceId);
                command.Parameters.AddWithValue("@questionId", questionId);
                command.Parameters.AddWithValue("@contestantId", contestantId);
                if (answerId != null)
                {
                    command.Parameters.AddWithValue("@answerId", answerId);
                }
                else
                {
                    command.Parameters.AddWithValue("@answerId", "");
                }
                command.Parameters.AddWithValue("@now", DateTime.Now);

                repository.ExecuteStatement(command);
                // The Complete method commits the transaction. If an exception has been thrown,
                // Complete is not  called and the transaction is rolled back.
                scope.Complete();
            }
        }

        /// <summary>
        /// Returns whether the answer was successful or not.
        /// Throws an Exception if the it is timeouted.
        /// </summary>
        /// <param name="contestant">The contestant, who attempts</param>
        /// <param name="question">The question that is being attempted</param>
        /// <param name="answer">The answer the contestant attempts with</param>
        /// <returns>Whether it was successful or not</returns>
        public bool IsAnswerCorrect(int quizInstanceId, int questionId, int? answerId)
        {
            System.IO.StringWriter writer = new System.IO.StringWriter();
            SqlCommand command = new SqlCommand();
            bool answerIsCorrect = false;
            try
            {
                //string commandText = @"SELECT QuestionInstance.[TimeOut], Question.CorrectAnswer FROM Question, QuestionInstance Where
                //        Question.id = "+quizInstanceId+" AND QuestionInstance.QuestionId = "+questionId+
                //        " AND QuestionInstance.QuizInstanceId = "+quizInstanceId;
                command.CommandText = @"SELECT QuestionInstance.TimeOut, Question.CorrectAnswer FROM Question, QuestionInstance Where
                        Question.id = @QuestionId AND QuestionInstance.QuestionId = @QuestionId AND
                        QuestionInstance.QuizInstanceId = @QuizInstanceId";

                command.Parameters.AddWithValue("@QuestionId", questionId);
                command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);

                // Create the TransactionScope to execute the commands, guaranteeing
                // that both commands can commit or roll back as a single unit of work.
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection = new SqlConnection(repository.ConnectionString))
                    {
                        // Opening the connection automatically enlists it in the 
                        // TransactionScope as a lightweight transaction.
                        connection.Open();

                        // Create the SqlCommand object and execute the first command.
                        //SqlCommand command = new SqlCommand(commandText, connection);
                        command.Connection = connection;
                        writer.WriteLine(command.CommandText);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            if (Convert.ToDateTime(reader["TimeOut"].ToString()).Ticks > DateTime.Now.Ticks)
                            {
                                if (answerId == Convert.ToInt32(reader["CorrectAnswer"]))
                                {
                                    answerIsCorrect = true;
                                }
                                else
                                {
                                    answerIsCorrect = false;
                                }
                            }
                            else
                            {
                                answerIsCorrect = false;
                            }
                        }
                    }
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                writer.WriteLine("TransactionAbortedException Message: {0}", ex.Message);
            }
            catch (ApplicationException ex)
            {
                writer.WriteLine("ApplicationException Message: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                writer.WriteLine("Other Exception Message: {0}", ex.Message);
            }
            Debug.WriteLine(writer.ToString());
            return answerIsCorrect;
        }

        /// <summary>
        /// Extracts all questions from DB
        /// </summary>
        /// <returns>List of questions</returns>
        public List<Question> GetAll()
        {
            List<Question> questions = new List<Question>();
            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Question";
            //foreach (Object obj in Repository.MultiRead(commandText, new Question()))
            //{
            //    questions.Add((Question)obj);
            //}
            return repository.MultiRead(command);
        }

        /// <summary>
        /// Returns all Questions on a Quiz
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Question> GetAllByQuizId(int id)
        {
            List<Question> questions = new List<Question>();
            SqlCommand command = new SqlCommand();
            //string commandText = @"SELECT Question.Id, Question.Header, Question.Text, Question.CreateDate, Question.CorrectAnswer
            //    FROM Question INNER JOIN QuizQuestion ON Question.Id = QuizQuestion.QuestionId AND QuizQuestion.QuizId = "+id;
            //foreach(Object obj in Repository.MultiRead(commandText, new Question()))
            //{
            //    questions.Add((Question)obj);
            //}

            command.CommandText = @"SELECT Question.Id, Question.Header, Question.Text, Question.CreateDate
                FROM Question INNER JOIN QuizQuestion ON Question.Id = QuizQuestion.QuestionId AND QuizQuestion.QuizId = @id";
            command.Parameters.AddWithValue("@id", id);

            return repository.MultiRead(command);
        }

        // does this need quiz id or quiz instance id or both?
        public int CreateQuestionInstances(int quizInstanceId)
        {
            Quiz quiz = new DBQuiz().GetQuizIdByInstanceId(quizInstanceId);
            

            if (quiz.Id == 0)
            {
                return 0;
            }

            List<Question> questions = GetAllByQuizId(quiz.Id);
            foreach (Question question in questions)
            {
                SqlCommand command = new SqlCommand();
                //string commandText = @"INSERT INTO QuestionInstance(QuizInstanceId, QuestionId, Header) 
                //VALUES ("+quizInstanceId+", "+question.Id+", '"+question.Header+"')";
                command.CommandText = @"INSERT INTO QuestionInstance(QuizInstanceId, QuestionId, Header) VALUES (@QuizInstanceId, @QuestionId, @Header)";

                command.Parameters.AddWithValue("@QuizInstanceId", quizInstanceId);
                command.Parameters.AddWithValue("@QuestionId", question.Id);
                command.Parameters.AddWithValue("@Header", question.Header);

                if (repository.ExecuteStatement(command) < 1)
                {
                    return 0;
                }
            }
            return 1;
        }

        /// <summary>
        /// Removes all QuestionInstances on a quiz
        /// *** outdated, uses Quiz Instance instead of quiz now and does not need
        /// *** to remove question instances
        /// </summary>
        //public void RemoveQuestionInstances(int quizId)
        //{
        //    SqlConnection con = Repository.GetConnection();
        //    bool wasConnectionOpen = true;
        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //        wasConnectionOpen = false;
        //    }
        //    SqlTransaction transaction = Repository.StartTransaction();
        //    SqlCommand command = con.CreateCommand();
        //    command.Transaction = transaction;

        //    try
        //    {
        //        command.CommandText = "DELETE FROM QuestionInstance WHERE QuizId = @quizId";
        //        command.Parameters.AddWithValue("@quizId", quizId);
        //        command.ExecuteNonQuery();
        //        if (!wasConnectionOpen)
        //        {
        //            transaction.Commit();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        if (!wasConnectionOpen)
        //        {
        //            try
        //            {
        //                transaction.Rollback();
        //            }
        //            catch (Exception)
        //            {

        //            }
        //        }
        //    }
        //    finally
        //    {
        //        command.Dispose();
        //        if (!wasConnectionOpen)
        //        {
        //            Repository.CloseTransaction();
        //            Repository.CloseConnection();
        //        }
        //    }
        //}
    }
}
