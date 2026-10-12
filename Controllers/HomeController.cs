using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HoangHaPC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult HoangHa()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CPU()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PCGiaRe()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult VGA()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Hotline()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Showroom()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}