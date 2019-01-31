using BLL.Model;
using BLL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace QuizService
{
    [ServiceContract]
    interface IWebQuizMasterService
    {
        [OperationContract]
        List<QuestionViewModel> GetQuestionView(Guid contestantId, int quizId);

        [OperationContract]
        Contestant InsertContestant(string Name, int quizId);

        [OperationContract]
        QuizInstance GetQuizByUserID(int userId);

        [OperationContract]
        int GetUserIdByName(string username);

        [OperationContract]
        Question GetQuestionToAnswer(Guid contestantId, int quizInstanceId, int questionId);

        [OperationContract]
        bool AttemptAnswer(int quizInstanceId, Guid contestantId, int questionId, int? answerId);

        [OperationContract]
        bool GetQuizRunningByQuizId(int quizId);
    }
}
