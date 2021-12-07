using System;
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
          const int _maxNumberOfGuilds = 4;
          var rnd = new Random();
          var random = rnd.Next(0, _maxNumberOfGuilds);
          if (_player.IsAlive)
          {
              switch (random)
              {
                    case 0:
                        var service = new GuildOfFoolsService();
                        PlayerFoolViewModel pfvm = new PlayerFoolViewModel
                        {
                            player = _player,
                            fool = new Fool(service.GetRandomFool(rnd).Practice, service.GetRandomFool(rnd).Fee)
                        };
                        TempData["NewFoolModel"] = pfvm;
                        return RedirectToAction("Index", "FoolsGuild",
                            pfvm);
                    case 1:
                        var service1 = new GuildOfBeggarsService();
                        PlayerBeggarViewModel pbvm = new PlayerBeggarViewModel
                        {
                            player = _player,
                            begar = new Beggar(service1.GetRandomBeggar(rnd).Practice, service1.GetRandomBeggar(rnd).Fee)
                        };
                        TempData["NewBeggarModel"] = pbvm;
                        return RedirectToAction("Index", "BeggarsGuild");
                    case 2:
                        PlayerThiefModel player = new PlayerThiefModel
                        {
                            player = _player,
                            thief = new Thief()
                        };
                        TempData["NewCustomer"] = player;
                        return RedirectToAction("Index", "ThievesGuild");
                    case 3:
                        PlayerAssassinViewModel pavm = new PlayerAssassinViewModel();
                        pavm.player = _player;
                        TempData["NewAssassinModel"] = pavm;
                        return RedirectToAction("Question", "AssassinsGuild");
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