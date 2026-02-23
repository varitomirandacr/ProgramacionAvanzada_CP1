using System.Web.Mvc;

namespace AP.MVC.Controllers
{
    public class AccessController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // For now allow empty user and pass; always redirect to Home
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}