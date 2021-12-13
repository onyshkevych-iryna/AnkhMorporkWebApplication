using System;
using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;
using AnkhMorporkWebApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class GameController : Controller
    {
        private readonly GuildOfBeggarsService _beggarService = new GuildOfBeggarsService();
        private readonly GuildOfFoolsService _foolService = new GuildOfFoolsService();
        private readonly GuildOfThievesService _thiefService = new GuildOfThievesService();

        public ActionResult Start()
        {
            var player = new Player();
            player.IsAlive = true;
            return RedirectToAction("Index", "Game", player);
        }

        public ActionResult Index(Player player)
        {
            const int maxNumberOfGuilds = 1;
            var rnd = new Random();
            var random = rnd.Next(0, maxNumberOfGuilds);
            if (player.IsAlive)
            {
                switch (random)
                {
                    //case 0:
                    //    TempData["FoolViewModel"] = _foolService.GetRandomFool(player, rnd);
                    //    return RedirectToAction("Index", "FoolsGuild");
                    //case 1:
                    //    TempData["BeggarViewModel"] = _beggarService.GetRandomBeggar(player, rnd);
                    //    return RedirectToAction("Index", "BeggarsGuild");
                    //case 2:
                    //    if (GuildOfThieves.NumberOfThieves > 0)
                    //    {
                    //        TempData["ThiefViewModel"] = _thiefService.GetThieve(player);
                    //        return RedirectToAction("Index", "ThievesGuild");
                    //    }
                    //    return RedirectToAction("Index", "Game", player);
                    case 0:
                        var assassinViewModel= new PlayerAssassinViewModel();
                        assassinViewModel.Player = player;
                        TempData["AssassinViewModel"] = assassinViewModel;
                        return RedirectToAction("Question", "AssassinsGuild");
                }
            }
            return RedirectToAction("EndOfGame", "Game");
        }
      
        public ActionResult EndOfGame(string slogan)
        {
            var mvm = new MessageViewModel
            {
                Message = slogan
            };
            return View(mvm);
        }
    }
}