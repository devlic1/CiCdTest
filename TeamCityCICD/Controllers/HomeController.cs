using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamCityCICD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var obj = new { Name = "Yogesh", Age = 35 };
            
            
            ViewBag.Result = obj.ToString();
            ViewBag.Result = MyNetStandard.Class1.MyMethod();
            ViewBag.Result = MyNetStandard.Class1.GetJson(obj);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}