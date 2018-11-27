using DevExpress.Web.Mvc;
using MonthYearPickerEditGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonthYearPickerEditGrid.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", null, "Months");    
        }
        [HttpPost]
        public ActionResult Index(string combo)
        {
            return View("Index", null, combo);
        }


        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = Data.GetData();
            return PartialView("_GridViewPartial", model);
        }
    }
}