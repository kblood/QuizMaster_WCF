using QuizWebClient.WebQuizMasterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizWebClient.Controllers
{
    public class QuizController : Controller
    {
        WebQuizMasterServiceClient quizService = new WebQuizMasterServiceClient();

        // GET: Quiz
        // Custom RouteConfig App_Start
        // "Quiz/{contestantId}/{action}/{quizId}"

        // Quiz is started, Model = List<QuestionViewModel>
        public ActionResult Index(Guid contestantId, int quizId)
        {

            // get and return view with model...
            var model = quizService.GetQuestionView(contestantId, quizId);
            if (model == null)
            {
                return View("Ended");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Ended()
        {
            return View();
        }
        #region waiting view

        // Starting point, loads partial view _IsRunning every 2 seconds
        public ActionResult Wait(Guid contestantId, int quizId)
        {
            return View();
        }

        // Called every 2 seconds by Wait view
        // Partial view in Wait. Returns a button or something when quiz is running
        public PartialViewResult IsRunning(Guid contestantId, int quizId)
        {
            bool running = quizService.GetQuizRunningByQuizId(quizId);

            return PartialView("_IsRunning", running);
        }

        #endregion
    }
}