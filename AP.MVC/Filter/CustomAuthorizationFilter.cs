using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AP.MVC.Filter
{
    public class CustomAuthorizationFilter : FilterAttribute, System.Web.Mvc.IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                // Name: Database "amiranda@gmai.com" = Roles (Admin)
                //filterContext.RequestContext.HttpContext.Response.Redirect("/Account/Login");
                filterContext.Result = new RedirectResult("/Account/Login");
            }
        }
    }
}