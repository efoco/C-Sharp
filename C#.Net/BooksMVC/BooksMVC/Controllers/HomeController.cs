using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Edo's Book Shop";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application simulates a bookshop";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "To Contact me, plese pray , if I do not answer it means you are not praying hard enough";

            return View();
        }
    }
}
