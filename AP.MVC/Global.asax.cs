using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Text;
using System.Diagnostics;

namespace AP.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_BeginRequest()
        {
            Response.ContentEncoding = Encoding.UTF8;
            Response.Charset = "utf-8";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            var exception = Server.GetLastError();
            if (exception == null)
            {
                return;
            }

            Trace.TraceError($"Unhandled exception at application level: {exception}");

            var httpException = exception as HttpException;
            var httpStatusCode = httpException?.GetHttpCode() ?? 500;
            var path = Request?.Path ?? string.Empty;

            // Prevent redirection loops if an error occurs on error pages.
            if (path.StartsWith("/Home/Error", StringComparison.OrdinalIgnoreCase) ||
                path.StartsWith("/Home/NotFound", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            Server.ClearError();
            Response.Clear();
            Response.TrySkipIisCustomErrors = true;
            Response.StatusCode = httpStatusCode;

            if (httpStatusCode == 404)
            {
                Response.Redirect("~/Home/NotFound", endResponse: false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            Response.Redirect("~/Home/Error", endResponse: false);
            Context.ApplicationInstance.CompleteRequest();
        }
    }
}
