using AP.Core;
using AP.MVC.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AP.MVC.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var semana03 = new Semana03(new Semana04());
            semana03.CreateWeek();

            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewData["Message"] = "This is the home page of your ASP.NET MVC application.";
            TempData["Message"] = "This message will persist across redirects.";
            return View();
        }

        public ActionResult About()
        {
            var one = 1;
            var zero = 0;
            var test = one/zero;
            var test1 = ViewBag.Message;// = "Your application description page.";
            var test2 = ViewData["Message"];
            var test3 = TempData["Message"];

            //throw new Exc("Test exception in About action.");

            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Error()
        {
            Response.StatusCode = 500;
            return View("~/Views/Shared/Error.cshtml");
        }

        [AllowAnonymous]
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View("~/Views/Shared/NotFound.cshtml");
        }
    }
}