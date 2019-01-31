using QuizWebClient.WebQuizMasterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizWebClient.Controllers
{
    public class QuestionController : Controller
    {
        WebQuizMasterServiceClient quizService = new WebQuizMasterServiceClient();

        // GET: Question
        public ActionResult Index(Guid contestantId, int quizId, int questionId)
        {
            ///
            /// FYI quizId is now quiz instance id; don't change
            ///

            // Out comment next line to redirect view afC:\Users\Ole\Source\Repos\My First Project\QuizMaster\QuizAdmin\UserViews\ter X(29) seconds 
            Response.AddHeader("Refresh", "30;url=/Quiz/Index/" + contestantId + "/" + quizId);

            Question question = quizService.GetQuestionToAnswer(contestantId, quizId, questionId);
            if (question == null)
            {
                // Return to quiz, and list of questions...
                return RedirectToAction("Index", "Quiz", new { contestantId = contestantId, quizId = quizId });
            }

            return View(question);
        }

        public ActionResult Answer(Guid contestantId, int quizId, int questionId, int answerId)
        {
            ///
            /// FYI quizId is now quiz instance id; don't change
            ///

            // DO STUFF
            bool answer = quizService.AttemptAnswer(quizId, contestantId, questionId, answerId);

             TempData["output"] = answer;

            // Return to quiz, and list of questions...
            return RedirectToAction( "Index", "Quiz",new { contestantId = contestantId, quizId = quizId });

        }
    }
}