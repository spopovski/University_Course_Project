using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HidroRemonti.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }

        public ActionResult Offers()
        {
            ViewBag.Message = "Your application description page.";

            return View("Offers");

        }


        public ActionResult Price_uluci()
        {
            ViewBag.Message = "Price uluci page.";

            return View("Price_uluci");

        }
        public ActionResult Price_konstrukcii()
        {
            ViewBag.Message = "Price_konstrukcii page.";

            return View("Price_konstrukcii");

        }
        public ActionResult Price_hidroizolaciq()
        {
            ViewBag.Message = "Price_hidroizolaciq page.";

            return View("Price_hidroizolaciq");

        }
        public ActionResult Price_pokriv_keremidi()
        {
            ViewBag.Message = "Price_pokriv_keremidi page.";

            return View("Price_pokriv_keremidi");

        }
        public ActionResult Zavursheni_obekti()
        {
            ViewBag.Message = "Zavursheni_obekti page.";

            return View("Zavursheni_obekti");

        }

    }
}