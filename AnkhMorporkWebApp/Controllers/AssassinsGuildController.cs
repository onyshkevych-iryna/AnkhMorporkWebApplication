using System.Linq;
using System.Web.Mvc;
using AnkhMorporkApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class AssassinsGuildController : Controller
    {


        // GET: AssassinsGuild
        public ActionResult Skip(Player player)
        {
            string message = player.Skip(typeof(Assassin));
            return RedirectToAction("EndOfGame", "Game", new {slogan = message});

        }

        public ActionResult About(decimal amount)
        {
            Player player = new Player(amount);
            PlayerAssassinViewModel pavm = new PlayerAssassinViewModel();
            pavm.player = player;
            return View(pavm);
        }

        public ActionResult Input(PlayerAssassinViewModel vm)
        {
            var guildOfAssassins = new GuildOfAssassins();
            var assassin = guildOfAssassins.Assassins
                .FirstOrDefault(a => a.MinReward <= vm.amount && a.MaxReward >= vm.amount && !a.IsOccupied);
            vm.player.GiveMoney(vm.amount);
            Player player = new Player(vm.player.Balance);
            return RedirectToAction("Index", "Home",player);
        }

        public ActionResult Question()
        {
            var model = TempData["NewAssassinModel"] as PlayerAssassinViewModel;

            return View(model);

        }
    }
}