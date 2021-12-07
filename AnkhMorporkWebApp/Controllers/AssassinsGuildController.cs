using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnkhMorporkApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class AssassinsGuildController : Controller
    {
        [HttpPost]
        public ActionResult Index(PlayerAssassinViewModel vm, string action)
        {
            if (action == "yes")
            {
                var guildOfAssassins = new GuildOfAssassins();
                var assassin = guildOfAssassins.Assassins
                    .FirstOrDefault(a => a.MinReward <= vm.amount && a.MaxReward >= vm.amount && !a.IsOccupied);
                Player player = new Player(vm.player.Balance);
                player.GiveMoney(vm.amount);
                return RedirectToAction("Index", "Home", player);
            }
            return RedirectToAction("EndOfGame", "Game");
        }

        // GET: AssassinsGuild
        public ActionResult About()
        {
            var model = TempData["NewAssassinModel"] as PlayerAssassinViewModel;
            return View(model);
        }
    }
}