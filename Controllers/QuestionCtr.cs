using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Model;
using DAL;
using BLL.ViewModel;
using System.Threading;

namespace Controllers
{
    public class QuestionCtr
    {
        private static Object lockGetQuestion = new Object();
        /// <summary>
        /// Creates an empty constructor
        /// </summary>
        public QuestionCtr()
        {
        }

        /// <summary>
        /// Creates and returns a new question
        /// </summary>
        /// <returns></returns>
        public Question CreateQuestion()
        {
            return new Question();
        }

        /// <summary>
        /// Saves question in DB
        /// </summary>
        /// <param name="question"></param>
        public void SaveQuestion(Question question)
        {
            if (question.CorrectAnswer != null && question.Answers.Count > 0
            && !string.IsNullOrWhiteSpace(question.Header) && !string.IsNullOrWhiteSpace(question.Text))
            {
                new DBQuestion().SaveQuestion(question);
            }
            else
            {
                // Maybe this needs to be defined better later.
                throw new Exception();
            }
        }

        /// <summary>
        /// Extracts all questions from the db
        /// </summary>
        public List<Question> GetQuestions()
        {
            return new DBQuestion().GetAll();
        }

        /// <summary>
        /// Get list of views from quizViewModel
        /// returns null if the list is empty, which should only happen if the quiz has stopped
        /// </summary>
        public List<QuestionViewModel> GetQuestionView(Guid contestantId, int quizId)
        {
            if(new DBQuizInstance().GetQuizRunningByContestantId(contestantId) == false)
            {
                return null;
            }

            List<QuestionViewModel> models = new DBQuestionInstance().SeeQuestionsOnQuiz(contestantId, quizId);
            if(!models.Any())
            {
                models = null;
            }
            return models;
        }

        /// <summary>
        /// Checks if contestant can answer a question and if true, returns a question with answers.
        /// </summary>
        /// <param name="contestantId"></param>
        /// <param name="quizInstanceId"></param>
        /// <param name="questionId"></param>
        /// <returns></returns>
        public Question GetQuestionToAnswer(Guid contestantId, int quizInstanceId, int questionId)
        {
            if(!new DBQuizInstance().GetQuizRunningById(quizInstanceId))
            {
                return null;
            }
            else 
            {
                Monitor.Enter(lockGetQuestion);
                if (new DBQuestionInstance().CanContestantAnswerQuestion(contestantId, quizInstanceId, questionId))
                {
                    AttemptAnswer(quizInstanceId, contestantId, questionId, null);
                    new DBQuestionInstance().SetQuestionInstanceTimeOut(quizInstanceId, questionId, DateTime.Now.AddSeconds(32));
                    //slut lås
                    Monitor.Exit(lockGetQuestion);
                    return new DBQuestion().GetQuestionWithAnswers(questionId);
                }
                else
                {
                    //slut lås
                    Monitor.Exit(lockGetQuestion);
                }
            }
            return null;
        }

        /// <summary>
        /// Returns all Questions attached to the quizId
        /// </summary>
        /// <param name="quizId"></param>
        /// <returns></returns>
        public List<Question> GetAllByQuizId(int quizId)
        {
            return new DBQuestion().GetAllByQuizId(quizId);
        }

        /// <summary>
        /// Is to be called when a user answers a question, or is timeouted.
        /// Returns whether it was successful or not.
        /// </summary>
        /// <param name="contestant">The contestant, who attempts</param>
        /// <param name="question">The question that is being attempted</param>
        /// <param name="answer">The answer the contestant attempts with. This should be null, if it was a timeout</param>
        /// <returns>Whether it was successful or not</returns>
        public bool AttemptAnswer(int quizInstanceId, Guid contestantId, int questionId, int? answerId)
        {
            DBQuestion dbQuestion = new DBQuestion();
            bool result;
            try
            {
                if (answerId != null)
                {
                    result = dbQuestion.IsAnswerCorrect(quizInstanceId, questionId, answerId);
                }
                else
                {
                    throw new TimeoutException();
                }
            }
            catch (TimeoutException)
            {
                result = false;
                answerId = null;
            }
            if (result)
            {
                dbQuestion.AnsweredCorrectly(quizInstanceId, contestantId, questionId);
            }
            else
            {
                dbQuestion.AnsweredWrong(quizInstanceId, contestantId, questionId, answerId);
            }
            return result;
        }
    }
}
