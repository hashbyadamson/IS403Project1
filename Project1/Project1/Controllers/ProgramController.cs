using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class ProgramController : Controller
    {
        // GET: Program
        public ActionResult Program()
        {

            return View();
        }

        public ActionResult ProgramView(string ProName, string InternName, string AgeGroup, string WeekdayTime, string ProDesc)
        {
            ViewBag.ProName = ProName;
            ViewBag.InternName = InternName;
            ViewBag.AgeGroup = AgeGroup;
            ViewBag.WeekdayTime = WeekdayTime;
            ViewBag.ProDesc = ProDesc;

            return View();
        }
    }
}