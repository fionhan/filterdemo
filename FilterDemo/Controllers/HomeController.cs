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

        public ActionResult TableTest(string userName)
        {
            // 测试-此处,如果直接在地址栏中输入url且参数中包含中文时,只有在IE中不会进行编码,
            //这样会导致接受的字符串为乱码,而在火狐和chrome中接受的参数均正常
            //所以在IE中,如果不是主动发请求而是从外部调用时,url在给的时候要进行编码
            //用Server.UrlEncode()将参数编码
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
