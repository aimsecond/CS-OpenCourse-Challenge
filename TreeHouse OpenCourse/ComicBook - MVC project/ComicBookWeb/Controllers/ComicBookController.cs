using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookWeb.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            //{
            //    return Redirect("http://www.google.com");
            //}
            //return Content("give me the apple!");

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.SeriesTitle = "The Amazing Spider-Man"; 
            return View();
        }
    }
}