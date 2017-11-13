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

        //Creates and assigns values to the programList List
        public IEnumerable<SelectListItem> ProgramDropDown()
        {
            List<SelectListItem> programList = new List<SelectListItem>();
            //adds the programs to the programList
            //In future it can grab from the model instead of hard coding
            programList.Add(new SelectListItem{Text = "Music",Value = "1"});
            programList.Add(new SelectListItem{Text = "Personal Finance",Value = "2"});
            programList.Add(new SelectListItem{Text = "Zumba",Value = "3"});

            //puts the list into an IEnumerable returnProgramList and returns it
            IEnumerable<SelectListItem> returnProgramList = programList;

            return returnProgramList;
        }


        public ActionResult Program()
        {
            //ViewModel viewModel = new ViewModel();
            ViewBag.Program = ProgramDropDown();
            
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