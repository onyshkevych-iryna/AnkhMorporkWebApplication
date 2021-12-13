using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class AssassinsGuildController : Controller
    {
        private GuildOfAssassins guild = new GuildOfAssassins();
        private Player _player;

        public ActionResult Question()
        {
            var model = TempData["AssassinViewModel"] as PlayerAssassinViewModel;
            return View(model);
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
            _player = guild.InteractionWithPlayer(action, out string controller, out string actionName,
                out string message, vm.player.Balance, vm.player.BeerAmount, vm.amount);
            return RedirectToAction(actionName, controller, _player);
        }

        public ActionResult No(string action)
        {
            guild.InteractionWithPlayer(action, out string controller, out string act,
                out string message);
            return RedirectToAction(act, controller, new { slogan = message });
        }
    }
}