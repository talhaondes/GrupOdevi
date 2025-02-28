using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationUI.Controllers
{
    public class MarketController : Controller
    {
        // GET: AnaSayfa
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}