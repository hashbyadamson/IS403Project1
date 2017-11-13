using System.Collections.Generic;
using System.Web.Mvc;

namespace Project1.Controllers
{
    internal class ViewModel
    {
        public ViewModel()
        {
        }

        public static IEnumerable<SelectListItem> Program { get; internal set; }
    }
}