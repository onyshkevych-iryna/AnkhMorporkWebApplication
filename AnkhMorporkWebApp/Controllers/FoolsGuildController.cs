using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnkhMorporkApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class FoolsGuildController : Controller
    {
        // GET: FoolsGuild
        public ActionResult Index(decimal fee, string practice)
        {
            var fool = new Fool(practice, fee);

            return View(fool);
        }

        public ActionResult Yes()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}