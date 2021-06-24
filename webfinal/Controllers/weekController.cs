using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webfinal.Controllers
{
    public class weekController : Controller
    {
        // GET: week
        public ActionResult Index(float? num)
        {
            var result = "";
            if (num.HasValue)
            {
                result = "星期"+num;
            }
            ViewBag.Name = num;
            ViewBag.Result = result;
            return View();
        }
    }
}