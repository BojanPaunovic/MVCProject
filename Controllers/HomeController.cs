using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjekatPSA.Controllers
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
        [HttpGet]
        public ActionResult UnosSatovi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnosSatovi(Models.Sat sat)
        {
            return View("PrikazSata", sat);
        }

        [HttpGet]
        public ActionResult UnosOgrlica()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnosOgrlica(Models.Ogrlica ogrlica)
        {
            return View("PrikazOgrlica", ogrlica);
        }

        [HttpGet]
        public ActionResult UnosPrsten()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UnosPrsten(Models.Prsten prsten)
        {
            return View("PrikazPrsten", prsten);
        }
    }
}