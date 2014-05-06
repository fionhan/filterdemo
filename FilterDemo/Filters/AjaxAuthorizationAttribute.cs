﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Filters
{
    public class AjaxAuthorizationAttribute:AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                UrlHelper urlHelper=new UrlHelper(filterContext.RequestContext);
                filterContext.Result = new JsonResult
                {
                    Data = new
                    {
                        Error="NotAuthorized",
                        LogOnUrl=urlHelper.Action("About","Home")
                    },JsonRequestBehavior=JsonRequestBehavior.AllowGet
                };
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}