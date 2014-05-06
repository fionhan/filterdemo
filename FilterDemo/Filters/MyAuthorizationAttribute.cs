using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Filters
{
    public class MyAuthorizationAttribute:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //return httpContext.Request.IsLocal || base.AuthorizeCore(httpContext);
            return false;
        }
    }
}