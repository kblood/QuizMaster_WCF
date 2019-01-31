using System.ServiceModel;
using BLL.Model;
using System.Collections.Generic;
using BLL.ViewModel;
using System;

namespace QuizService
{
    [ServiceContract]
    public interface IQuizMasterService
    {
        [OperationContract]
        Quiz CreateQuiz(string title, string description, User author);

        [OperationContract]
        User Login(string username, string password);

        [OperationContract]
        List<Quiz> GetQuizes();

        [OperationContract]
        int InsertUser(string username, string password);

        [OperationContract]
        Question CreateQuestion();

        [OperationContract]
        void SaveQuestion(Question question);

        [OperationContract]
        List<Question> GetQuestions();

        [OperationContract]
        QuizInstance OpenQuiz(Quiz quiz, User user);

        [OperationContract]
        void CloseQuiz(QuizInstance quizInstance);

        [OperationContract]
        void RunQuiz(QuizInstance quizInstance);

        [OperationContract]
        bool GetQuizRunningById(int quizId);

        [OperationContract]
        void AddQuestion(int quizId, int questionId);

        [OperationContract]
        void RemoveQuestion(int quizId, int questionId);

        [OperationContract]
        List<QuizInstance> GetQuizInstances(User user);

        [OperationContract]
        QuizInstance GetQuizInstanceById(int quizInstanceId);

        /// <summary>
        /// returns a List of all Questions attached to the quizId
        /// </summary>
        /// <param name="quizId"></param>
        /// <returns></returns>
        [OperationContract]
        List<Question> GetAllByQuizId(int quizId);

        [OperationContract]
        QuizInstance GetActiveQuizByUserId(int userId);

        [OperationContract]
        void DeleteQuiz(int quizId);

        #region MVC
        /// <summary>
        /// From .dto QuestionViewModel
        /// </summary>
        /// <returns></returns>
        //[OperationContract]
        //List<QuestionViewModel> GetQuestionView(Guid contestantId, int quizId);

        //[OperationContract]
        //Contestant InsertContestant(string Name, int quizId);

        //[OperationContract]
        //QuizInstance GetQuizByUserID(int userId);

        //[OperationContract]
        //int GetUserIdByName(string username);

        //[OperationContract]
        //Question GetQuestionToAnswer(Guid contestantId, int quizInstanceId, int questionId);

        //[OperationContract]
        //bool AttemptAnswer(int quizInstanceId, Guid contestantId, int questionId, int? answerId);

        #endregion

    }
}
