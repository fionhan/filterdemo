using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilterDemo.Filters;

namespace FilterDemo.Controllers
{
    public class HomeController : Controller
    {
        //[MyAuthorization(Users = "bob,amy,penny", Roles = "admin")]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        //Add By Hpp On 2014-5-6 测试失败,待查
        //[AjaxAuthorizationAttribute]
        //[MyAuthorization(Users = "bob,amy,penny", Roles = "admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
