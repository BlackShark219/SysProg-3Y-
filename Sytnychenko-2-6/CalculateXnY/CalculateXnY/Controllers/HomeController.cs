using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library_3;
using Library_4;




namespace CalculateXnY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Calc(double x, double y)
        {
            var func = new KI3_Class_3();
            var res = func.F3(x, y) + 2 * KI3_Class_4.F4(x, y);
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}