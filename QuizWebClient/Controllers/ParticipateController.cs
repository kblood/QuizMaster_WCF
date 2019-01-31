using QuizWebClient.WebQuizMasterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace QuizWebClient.Controllers
{
    public class ParticipateController : Controller
    {
        WebQuizMasterServiceClient quizService = new WebQuizMasterServiceClient();

        // GET Quiz where open and author id equals (id)
        // Called by DefaultController with author id as query string (id)

        public ActionResult Join(int id)
        {
            var model = quizService.GetQuizByUserID(id);

            if(model == null)
            {
                // no author found. return index view with error message

                ViewBag.Error = "Denne underviser har ingen quizzer som er åben for deltagelse.";

                return View();
            }
            return View(model);
        }

        #region Contestant Login GET/POST

        /// <summary>
        /// GET ContestantLogin
        /// Called by Index button, quizId as query string /Participate/Join/(id) 
        /// </summary>
        public ActionResult ContestantLogin(int id)
        {
            return View();
        }

        /// <summary>
        /// POST ContestantLogin
        /// FORM POST quizId as query string (id) and contestant name from input field
        /// </summary>
        [HttpPost]
        public ActionResult ContestantLogin(int id, string name)
        {
            // creates and return new Contestant
            if (!string.IsNullOrWhiteSpace(name))
            {
                Contestant model = quizService.InsertContestant(name, id);

                // Done, redirect the newly created contestant to Quiz controller, Wait view
                return RedirectToAction("Wait", "Quiz", new { contestantId = model.Id, quizId = id });
            }

            // Error message
            ViewBag.Error = "Du skal indtaste navn";
            // Try again GET ContestantLogin
            return View();
        }
        #endregion
    }
}