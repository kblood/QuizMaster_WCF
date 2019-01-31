using BLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// This DB Quiz class is meant to get a quiz or quizzes
    /// from the database and write a quiz or quizzes to the
    /// database
    /// </summary>
    public class DBQuiz
    {
        // Database handler
        private Repository<Quiz> repository = new Repository<Quiz>();

        /// <summary>
        /// Gets all quizzes from the database
        /// </summary>
        /// <returns>A list of quizzes</returns>
        public List<Quiz> GetAll()
        {
            var command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Quiz WHERE Exclude = 0";
            List<Quiz> quizzes = repository.MultiRead(command);
            foreach(Quiz quiz in quizzes)
            {
                quiz.Author = new DBUser().GetById(quiz.AuthorId);
            }

            return repository.MultiRead(command);
        }

        /// <summary>
        /// Tests saving quiz to database
        /// </summary>
        /// <param name="quiz"></param>
        public void SaveQuiz(Quiz quiz)
        {
            var command = new SqlCommand();

            command.CommandText = @"INSERT INTO Quiz(Title, Description, CreateDate, UpdatedDate, AuthorId) VALUES (@Title, @Description, @CreateDate, @UpdatedDate, @AuthorId)";

            command.Parameters.AddWithValue("@Title", quiz.Title);
            command.Parameters.AddWithValue("@Description", quiz.Description);
            command.Parameters.AddWithValue("@CreateDate", quiz.CreateDate);
            command.Parameters.AddWithValue("@UpdatedDate", quiz.UpdatedDate);
            command.Parameters.AddWithValue("@AuthorId", quiz.Author.Id);

            repository.ExecuteStatement(command);
        }

        //this seems to need a transaction for some reason
        public Quiz GetQuizIdByInstanceId(int quizInstanceId)
        {
            var command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Quiz WHERE Id = (SELECT QuizId FROM QuizInstance WHERE Id = @id)";
            command.Parameters.AddWithValue("@id", quizInstanceId);

            Quiz quiz = repository.SingleRead(command);

            if(quiz.Id == 0)
            {
                quiz = null;
            }

            quiz.Author = new DBUser().GetById(quiz.AuthorId);

            return quiz;
        }

        /// <summary>
        /// Adds a Question to a Quiz
        /// </summary>
        /// <param name="quizId"></param>
        /// <param name="questionId"></param>
        public void AddQuestion(int quizId, int questionId)
        {
            var command = new SqlCommand();
            command.CommandText = @"INSERT INTO QuizQuestion(QuizId, QuestionId) VALUES (@quizId, @questionId)";

            command.Parameters.AddWithValue("@quizId", quizId);
            command.Parameters.AddWithValue("@questionId", questionId);

            repository.ExecuteStatement(command);
        }

        /// <summary>
        /// Adds a Question to a Quiz
        /// </summary>
        /// <param name="quizId"></param>
        /// <param name="questionId"></param>
        public void RemoveQuestion(int quizId, int questionId)
        {
            var command = new SqlCommand();
            command.CommandText = @"DELETE FROM QuizQuestion WHERE QuizId = @quizId AND QuestionId = @questionId";

            command.Parameters.AddWithValue("@quizId", quizId);
            command.Parameters.AddWithValue("@questionId", questionId);

            repository.ExecuteStatement(command);
        }

        /// <summary>
        /// Opens a QuizInstance of a quiz and returns it
        /// </summary>
        /// <param name="quiz">The Quiz that is to be opened</param>
        /// <param name="user">The User who opens it</param>
        public QuizInstance OpenQuiz(Quiz quiz, User user)
        {
            return new DBQuizInstance().OpenQuiz(quiz, user);
        }

        /// <summary>
        /// Closes a quiz, so that it no longer is possible to add more contestants
        /// </summary>
        /// <param name="quizInstance">The instance, that is to be closed</param>
        public void CloseQuiz(QuizInstance quizInstance)
        {
            new DBQuizInstance().CloseQuiz(quizInstance);
        }

        /// <summary>
        /// Returns a quiz with the quizInstance Id instead of its quiz Id that is open and has the userId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public QuizInstance GetQuizByUserId(int userId)
        {
            return new DBQuizInstance().GetQuizInstanceByUserId(userId);
        }

        public Quiz GetQuizById(int quizId)
        {
            var command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Quiz WHERE Id = @Id";
            command.Parameters.AddWithValue("@Id", quizId);

            Quiz quiz = repository.SingleRead(command);

            if(quiz.Id == 0)
            {
                quiz = null;
            }
            quiz.Author = new DBUser().GetById(quiz.AuthorId);
            return quiz;
        }

        /// <summary>
        /// Checks whether a quizInstance is running by quizInstance id
        /// </summary>
        /// <param name="quizInstanceId">The ID of the QuizInstance</param>
        public bool GetQuizRunningById(int quizInstanceId)
        {
            return new DBQuizInstance().GetQuizRunningById(quizInstanceId);
        }

        /// <summary>
        /// Sets whether the QuizInstance is running or not
        /// </summary>
        /// <param name="quizInstance">QuizInstance that is to be changed. Only the "running" and "id" attributes are used</param>
        public void RunQuiz(QuizInstance quizInstance)
        {
            new DBQuizInstance().RunQuiz(quizInstance);
        }

        /// <summary>
        /// Deletes a quiz so it is no longer shown on the quiz list
        /// </summary>
        public void DeleteQuiz(int quizId)
        {
            var command = new SqlCommand();
            command.CommandText = @"UPDATE Quiz SET Exclude = 1 WHERE Id = @id";
            command.Parameters.AddWithValue("@Id", quizId);

            repository.ExecuteStatement(command);
        }

        /// <summary>
        /// An Object Builder class to build new objects
        /// 
        /// Does not set the author yet
        /// 
        /// </summary>
        /// <param name="reader">a reader object with data from the database</param>
        /// <returns>a new quiz object</returns>
        //public Quiz ObjectBuilder(SqlDataReader reader)
        //{
        //    Quiz quiz = new Quiz();

        //    quiz.Id = int.Parse(reader["Id"].ToString());
        //    quiz.Title = reader["Title"].ToString();
        //    quiz.Description = reader["Description"].ToString();
        //    quiz.CreateDate = Convert.ToDateTime(reader["CreateDate"].ToString());
        //    quiz.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"].ToString());
        //    quiz.Open = Convert.ToBoolean(reader["Open"].ToString());
        //    return quiz;
        //}

        /// <summary>
        /// A generic object builder that takes the properties from the reader and puts into a
        /// new object of the same type as the destination object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        //private static object ReflectionObjectBuilder(SqlDataReader reader, object destination)
        //{
        //    //Type sourceType = source.GetType();
        //    Type destinationType = destination.GetType();

        //    object result = Activator.CreateInstance(destinationType);

        //    // columns is a list of attribute names in the reader
        //    var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();

        //    // We get properties from the destination type instead of the source type
        //    foreach (PropertyInfo pi in destinationType.GetProperties())
        //    {
        //        // set pDest to the currently instanced property type
        //        var pDest = destinationType.GetProperty(pi.Name);
        //        if (pDest != null && pDest.CanWrite)
        //        {
        //            // Make sure the current property name can be found in the reader
        //            if (columns.Contains(pi.Name))
        //            {
        //                if (pDest.PropertyType == typeof(int))
        //                    pDest.SetValue(result, Convert.ToInt32(reader[pi.Name]));
        //                else if (pDest.PropertyType == typeof(float))
        //                    pDest.SetValue(result, Convert.ToSingle(reader[pi.Name]));
        //                else if (pDest.PropertyType == typeof(double))
        //                    pDest.SetValue(result, Convert.ToDouble(reader[pi.Name]));
        //                else if (pDest.PropertyType == typeof(Boolean))
        //                    pDest.SetValue(result, Convert.ToBoolean(reader[pi.Name]));
        //                else if (pDest.PropertyType == typeof(DateTime))
        //                    pDest.SetValue(result, Convert.ToDateTime(reader[pi.Name]));
        //                else if (pDest.PropertyType == typeof(string))
        //                    pDest.SetValue(result, Convert.ToString(reader[pi.Name]));
        //            }
        //        }
        //    }

        //    return result;
        //}
    }
}
