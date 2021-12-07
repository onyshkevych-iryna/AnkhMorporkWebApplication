﻿using System;
using System.Web.Mvc;
using AnkhMorporkWebApp.Models;
using AnkhMorporkApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public ActionResult Index(Player _player)
        {
            int e = 3;
            const int _maxNumberOfGuilds = 1;
          var rnd = new Random();
          var random = rnd.Next(0, _maxNumberOfGuilds);
          if (_player.IsAlive)
          {
              switch (random)
              {
                  //case 0:
                  //    var service = new GuildOfFoolsService();
                  //    return RedirectToAction("Index", "FoolsGuild",
                  //        new {fee = service.GetRandomFool(rnd).Fee, practice = service.GetRandomFool(rnd).Practice});
                  //case 1:
                  //    var service1 = new GuildOfBeggarsService();
                  //    return RedirectToAction("Index", "BeggarsGuild",
                  //        new
                  //        {
                  //            fee = service1.GetRandomBeggar(rnd).Fee, practice = service1.GetRandomBeggar(rnd).Practice
                  //        });
                  case 0:
                      e--;
                        PlayerThiefModel player = new PlayerThiefModel
                        {
                            player = _player,
                            thief = new Thief()
                        };
                        TempData["NewCustomer"] = player;

                        return RedirectToAction("Index", "ThievesGuild");
                  //case 3:
                  //    return RedirectToAction("About", "AssassinsGuild");
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