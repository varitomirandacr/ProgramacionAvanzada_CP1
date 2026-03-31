using AP.Core.Exceptions;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace AP.MVC.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void ExecuteCore()
        {
            try
            {
                base.ExecuteCore();
            }
            catch (AppException ex)
            {
                Trace.TraceWarning($"Application exception handled in {GetType().Name}: {ex}");
                RedirectToGlobalErrorPage();
            }
            catch (Exception ex)
            {
                Trace.TraceError($"Unhandled exception in {GetType().Name}: {ex}");
                RedirectToGlobalErrorPage();
            }
        }

        private void RedirectToGlobalErrorPage()
        {
            Response.Clear();
            Response.StatusCode = 500;
            Response.TrySkipIisCustomErrors = true;
            Response.Redirect("~/Home/Error", endResponse: false);
            HttpContext.ApplicationInstance.CompleteRequest();
        }
    }
}
