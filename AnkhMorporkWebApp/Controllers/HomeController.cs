using System;
using System.Web.Mvc;
using AnkhMorporkWebApp.Models;
using AnkhMorporkWebApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class HomeController : Controller
    {
       private GuildOfBeggarsService bservice = new GuildOfBeggarsService();
       private GuildOfFoolsService fservice = new GuildOfFoolsService();
       private GuildOfThievesService tservice = new GuildOfThievesService();

       public ActionResult Index(Player _player)
       {
          const int _maxNumberOfGuilds = 4;
          var rnd = new Random();
          var random = rnd.Next(0, _maxNumberOfGuilds);
          if (_player.IsAlive)
          {
              switch (random)
              {
                    case 0:
                        TempData["NewFoolModel"] = fservice.GetRandomFool(_player, rnd);
                        return RedirectToAction("Index", "FoolsGuild");
                    case 1:
                        TempData["NewBeggarModel"] = bservice.GetRandomBeggar(_player, rnd);
                        return RedirectToAction("Index", "BeggarsGuild");
                    case 2:
                        TempData["NewCustomer"] = tservice.GetThieve(_player);
                        return RedirectToAction("Index", "ThievesGuild");
                    case 3:
                        PlayerAssassinViewModel pavm = new PlayerAssassinViewModel();
                        pavm.player = _player;
                        TempData["NewAssassinModel"] = pavm;
                        return RedirectToAction("Question", "AssassinsGuild");
              }
          }
          return RedirectToAction("EndOfGame", "Game");
       }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
    }
}