using System;
using System.Web.Mvc;
using AnkhMorporkWebApp.Models;
using AnkhMorporkWebApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class GameController : Controller
    {
        private readonly GuildOfBeggarsService _beggarService = new GuildOfBeggarsService();
        private readonly GuildOfFoolsService _foolService = new GuildOfFoolsService();
        private readonly GuildOfThievesService _thiefservice = new GuildOfThievesService();

        public ActionResult Start()
        {
            Player player = new Player();
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
                    //    TempData["ThiefViewModel"] = _thiefservice.GetThieve(player);
                    //    return RedirectToAction("Index", "ThievesGuild");
                    case 0:
                        PlayerAssassinViewModel pavm = new PlayerAssassinViewModel();
                        pavm.player = player;
                        TempData["AssassinViewModel"] = pavm;
                        return RedirectToAction("Question", "AssassinsGuild");
                }
            }
            return RedirectToAction("EndOfGame", "Game");
        }
      
        public ActionResult EndOfGame(string slogan)
        {
            MessageViewModel mvm = new MessageViewModel
            {
                Message = slogan
            };
            return View(mvm);
        }
    }
}