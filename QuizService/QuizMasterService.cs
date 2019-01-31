using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Model;
using BLL.ViewModel;
using Controllers;

namespace QuizService
{
    public class QuizMasterService : IQuizMasterService, IWebQuizMasterService
    {
        public Quiz CreateQuiz(string title, string description, User author)
        {
            return new QuizCtr().CreateAndSaveQuiz(title, description, author);
        }

        public User Login(string username, string password)
        {
            return new UserCtr().ValidateUser(username, password);
        }

        public List<Quiz> GetQuizes()
        {
            return new QuizCtr().GetQuizes();
        }

        public int InsertUser(string username, string password)
        {
            return new UserCtr().InsertUser(username, password);
        }

        public Question CreateQuestion()
        {
            return new QuestionCtr().CreateQuestion();
        }

        public void SaveQuestion(Question question)
        {
            new QuestionCtr().SaveQuestion(question);
        }

        public QuizInstance OpenQuiz(Quiz quiz, User user)
        {
            return new QuizCtr().OpenQuiz(quiz, user);
        }

        public void RunQuiz(QuizInstance quizInstance)
        {
            new QuizCtr().RunQuiz(quizInstance);
        }

        public bool GetQuizRunningById(int quizId)
        {
            return new QuizCtr().GetQuizRunningById(quizId);
        }

        public List<Question> GetQuestions()
        {
            return new QuestionCtr().GetQuestions();
        }

        public void AddQuestion(int quizId, int questionId)
        {
            new QuizCtr().AddQuestion(quizId, questionId);
        }

        public void RemoveQuestion(int quizId, int questionId)
        {
            new QuizCtr().RemoveQuestion(quizId, questionId);
        }

        public void CloseQuiz(QuizInstance quizInstance)
        {
            new QuizCtr().CloseQuiz(quizInstance);
        }

        public List<Question> GetAllByQuizId(int quizId)
        {
            return new QuestionCtr().GetAllByQuizId(quizId);
        }
        
        public QuizInstance GetActiveQuizByUserId(int userId)
        {
            return new QuizCtr().GetActiveQuizByUserId(userId);
        }

        public void DeleteQuiz(int quizId)
        {
            new QuizCtr().DeleteQuiz(quizId);
        }

        public List<QuizInstance> GetQuizInstances(User user)
        {
            return new QuizCtr().GetAllQuizInstancesByUserId(user.Id);
        }

        public QuizInstance GetQuizInstanceById(int quizInstanceId)
        {
            return new QuizCtr().GetQuizInstanceById(quizInstanceId);
        }

        #region MVC
        public List<QuestionViewModel> GetQuestionView(Guid contestantId, int quizInstanceId)
        {
            return new QuestionCtr().GetQuestionView(contestantId, quizInstanceId);
        }

        public Contestant InsertContestant(string Name, int quizInstanceId)
        {
            return new ContestantCtr().InsertContestant(Name, quizInstanceId);
        }

        public int GetUserIdByName(string username)
        {
            return new UserCtr().GetUserID(username);
        }

        public QuizInstance GetQuizByUserID(int userId)
        {
            return new QuizCtr().GetActiveQuizInstance(userId);
        }


        public Question GetQuestionToAnswer(Guid contestantId, int quizInstanceId, int questionId)
        {
            return new QuestionCtr().GetQuestionToAnswer(contestantId, quizInstanceId, questionId);
        }

        public bool AttemptAnswer(int quizInstanceId, Guid contestantId, int questionId, int? answerId)
        {
            return new QuestionCtr().AttemptAnswer(quizInstanceId, contestantId, questionId, answerId);
        }

        public bool GetQuizRunningByQuizId(int quizId)
        {
            return new QuizCtr().GetQuizRunningById(quizId);
        }


        #endregion

    }
}