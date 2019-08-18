using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Infrastructure
{
    public class LoginAuthoriaeAttritube: AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase  httpContext)
        {
            return httpContext.Session["aa"] != null;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //base.HandleUnauthorizedRequest(filterContext);
            filterContext.Result = new RedirectResult("/Login/Login");
        }

    }
}