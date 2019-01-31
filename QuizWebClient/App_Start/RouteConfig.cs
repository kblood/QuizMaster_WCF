using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace QuizWebClient
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            // CUSTOM  get the Contestant id {contestantId} and quiz id {quizId}
            routes.MapRoute(
               name: "QuizRoute",
               url: "{controller}/{action}/{contestantId}/{quizId}/{questionId}",
               defaults: new { controller = "Quiz", action = "Index", questionId = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional }
          );





            routes.MapRoute(
               name: "PartialRoute",
               url: "Quiz/index/{contestantId}/{quizId}/",
               defaults: new { controller = "Quiz" }
            );

        }
    }
}
