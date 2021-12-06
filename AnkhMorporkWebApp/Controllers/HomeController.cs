using System;
using System.Web.Mvc;
using AnkhMorporkApp.Models;
using AnkhMorporkApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
            var _player = new Player();
            const int _maxNumberOfGuilds = 4;
          _player.IsAlive = true;
          var rnd = new Random();
          var random = rnd.Next(0, _maxNumberOfGuilds);
          if (_player.IsAlive)
          {
              switch (random)
              {
                  case 0:
                      var service = new GuildOfFoolsService();
                      return RedirectToAction("Index", "FoolsGuild",
                          new {fee = service.GetRandomFool(rnd).Fee, practice = service.GetRandomFool(rnd).Practice});
                  case 1:
                      var service1 = new GuildOfBeggarsService();
                      return RedirectToAction("Index", "BeggarsGuild",
                          new
                          {
                              fee = service1.GetRandomBeggar(rnd).Fee, practice = service1.GetRandomBeggar(rnd).Practice
                          });
                  case 2:
                      return RedirectToAction("Index", "ThievesGuild");
                  case 3:
                      return RedirectToAction("About", "AssassinsGuild");
              }
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