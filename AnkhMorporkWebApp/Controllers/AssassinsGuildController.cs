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
        public ActionResult Index(PlayerAssassinViewModel vm)
        {
            var guildOfAssassins = new GuildOfAssassins();
                var assassin = guildOfAssassins.Assassins
                    .FirstOrDefault(a => a.MinReward <= vm.amount && a.MaxReward >= vm.amount && !a.IsOccupied);
                Player player = new Player(vm.player.Balance);
                player.GiveMoney(vm.amount);
                return RedirectToAction("Index", "Home", player);
        }

        // GET: AssassinsGuild
        public ActionResult About()
        {
            var model = TempData["NewAssassinModel"] as PlayerAssassinViewModel;
            return View(model);
        }
    }
}