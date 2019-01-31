using BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Controllers
{
    public class QuizCtr
    {
        public List<QuizInstance> GetAllQuizInstancesByUserId(int userId)
        {
            return new DBQuizInstance().GetQuizInstancesByUserId(userId);
        }

        public QuizInstance GetQuizInstanceById(int quizInstanceId)
        {
            return new DBQuizInstance().GetQuizInstanceById(quizInstanceId, true);
        }

        /// <summary>
        /// Creates and returns a Quiz.
        /// </summary>
        public Quiz CreateQuiz(string title, string description, User author)
        {
            Quiz quiz = new Quiz();
            quiz.Title = title;
            quiz.Description = description;
            quiz.Author = author;
            return quiz;
        }

        /// <summary>
        /// Saves a quiz to DB
        /// </summary>
        /// <param name="quiz"></param>
        private void SaveQuiz(Quiz quiz)
        {
            try
            {
                new DBQuiz().SaveQuiz(quiz);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
            }
        }

        /// <summary>
        /// Sets quiz to open in DB. Returns the newly-made Instance of the quiz.
        /// </summary>
        /// <param name="quiz">The Quiz that is to be opened</param>
        /// <param name="user">The User who opens it</param>
        public QuizInstance OpenQuiz(Quiz quiz, User user)
        {
            return new DBQuiz().OpenQuiz(quiz, user);
        }

        /// <summary>
        /// Sets closes a QuizInstance for anymore Contestants in DB
        /// </summary>
        /// <param name="quizInstance">The QuizInstance that is to be closed</param>
        public void CloseQuiz(QuizInstance quizInstance)
        {
            new DBQuiz().CloseQuiz(quizInstance);
        }

        /// <summary>
        /// Runs or stops the given QuizInstance
        /// </summary>
        /// <param name="quizInstance">The instance that is to be run/stopped</param>
        public void RunQuiz(QuizInstance quizInstance)
        {
            new DBQuiz().CloseQuiz(quizInstance);
            new DBQuiz().RunQuiz(quizInstance);
        }

        /// <summary>
        /// Checks whether a QuizInstance is running by QuizInstanceId
        /// </summary>
        /// <param name="quizInstanceId">The ID of the QuizInstance</param>
        public bool GetQuizRunningById(int quizInstanceId)
        {
            return new DBQuiz().GetQuizRunningById(quizInstanceId);
        }
        /// <summary>
        /// Returns quizInstans if active or null
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Active quizInstans</returns>
        public QuizInstance GetActiveQuizByUserId(int userId)
        {
            QuizInstance quizInstans = new DBQuizInstance().GetActiveQuizInstance(userId);

            return quizInstans;
        }

        /// <summary>
        /// Creates a new quiz model and saves it to db
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        public Quiz CreateAndSaveQuiz(string title, string description, User author)
        {
            Quiz quiz = CreateQuiz(title, description, author);
            SaveQuiz(quiz);
            return quiz;
        }

        /// <summary>
        /// Gets a list of all quizzes in db.
        /// </summary>
        /// <returns></returns>
        public List<Quiz> GetQuizes()
        {
            return new DBQuiz().GetAll();
        }

        /// <summary>
        /// Adds a Question to a Quiz
        /// </summary>
        /// <param name="quizId"></param>
        /// <param name="questionId"></param>
        public void AddQuestion(int quizId, int questionId)
        {
            new DBQuiz().AddQuestion(quizId, questionId);
        }

        /// <summary>
        /// Removes a Question to a Quiz
        /// </summary>
        /// <param name="quizId"></param>
        /// <param name="questionId"></param>
        public void RemoveQuestion(int quizId, int questionId)
        {
            new DBQuiz().RemoveQuestion(quizId, questionId);

        }

        public QuizInstance GetActiveQuizInstance(int userId)
        {
            return new DBQuiz().GetQuizByUserId(userId);
        }

        public void DeleteQuiz(int quizId)
        {
            new DBQuiz().DeleteQuiz(quizId);
        }
    }
}
