using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnkhMorporkApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class BeggarsGuildController : Controller
    {
        // GET: BeggarssGuild
        public ActionResult Index(decimal fee, string practice)
        {
            var beggar = new Beggar(practice, fee);

            return View(beggar);
        }

        public ActionResult Yes()
        {

            return RedirectToAction("Index", "Home");
        }
    }
}