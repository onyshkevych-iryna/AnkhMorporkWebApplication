using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using AnkhMorporkApp.Guilds;
using AnkhMorporkApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Player _player = new Player();
          const int _maxNumberOfGuilds = 4;
          _player.IsAlive = true;
          var rnd = new Random();
          var random = rnd.Next(0, _maxNumberOfGuilds);
          if (_player.IsAlive)
          {
              var guildOfFools = new GuildOfFools();
              var fools = guildOfFools.Fools;
              var randomFool = fools[rnd.Next(1, fools.Count + 1)];
              return RedirectToAction("Index", "ThievesGuild",
                  new { fee = randomFool.Fee, practice = randomFool.Practice });
          }
                 
           
          return Content(random.ToString());
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
    }
}