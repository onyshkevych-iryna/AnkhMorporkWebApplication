using System.Linq;
using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class AssassinsGuildController : Controller
    {
        private ApplicationContext db = new ApplicationContext();
        private GuildOfAssassins guild = new GuildOfAssassins();
        private Player _player;

        public ActionResult No(string action, Player player)
        {
            guild.InteractionWithPlayer(action, out string con, out string act,
                out string message);
            return RedirectToAction(act, con, new { slogan = message });
        }

        public ActionResult About(decimal amount)
        {
            _player = new Player(amount);
            PlayerAssassinViewModel pavm = new PlayerAssassinViewModel
            {
                balanceOfPlayer = amount,
                player = _player
            };
            return View(pavm);
        }

        public ActionResult Yes(string action, PlayerAssassinViewModel vm)
        {
            //if (vm.player.IsOutOfMoney(vm.player.Balance))
            //    return RedirectToAction("EndOfGame", "Game");

            _player = guild.InteractionWithPlayer(action, out string controller, out string actionName,
                out string message, vm.player.Balance, vm.player.BeerAmount, vm.amount);
            return RedirectToAction(actionName, controller, _player);
        }

        public ActionResult Question()
        {
            var model = TempData["NewAssassinModel"] as PlayerAssassinViewModel;
            return View(model);
        }
    }
}