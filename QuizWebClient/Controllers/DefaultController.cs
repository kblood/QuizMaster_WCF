using QuizWebClient.WebQuizMasterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizWebClient.Controllers
{
    /// <summary>
    /// Home controller
    /// </summary>
    public class DefaultController : Controller
    {
        WebQuizMasterServiceClient quizService = new WebQuizMasterServiceClient();
  
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(string authorInitials)
        {
            int userID = quizService.GetUserIdByName(authorInitials);

            if (userID != 0)
            {
                // If author exists go to Participate Controller / Join with ID of author as query string
                return RedirectToAction("Join", "Participate", new { id = userID });
            }
            else
            {
                // No author found. Return index view with error message
                ViewBag.Error = "Der er ingen underviser kaldet "  + authorInitials;
                return View();
            }
        }
    }
}