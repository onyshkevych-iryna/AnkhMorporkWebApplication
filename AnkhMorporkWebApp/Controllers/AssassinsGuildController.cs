using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class AssassinsGuildController : Controller
    {
        private readonly GuildOfAssassins _guild = new GuildOfAssassins();
        private Player _player;

        public ActionResult Question()
        {
            var model = TempData["AssassinViewModel"] as PlayerAssassinViewModel;
            return View(model);
        }

        public ActionResult About(decimal amount, int amountOfBeer)
        {
            _player = new Player(amount, amountOfBeer);
            var assassinViewModel = new PlayerAssassinViewModel
            {
                BalanceOfPlayer = amount,
                Player = _player,
              };
            return View(assassinViewModel);
        }

        public ActionResult Yes(string action, PlayerAssassinViewModel vm)
        {
            _player = _guild.InteractionWithPlayer(action,  out string actionName,
                out string message, vm.Player.Balance, vm.Player.BeerAmount, vm.Amount);
            return RedirectToAction(actionName, "Game", _player);
        }

        public ActionResult No(string action)
        {
            _guild.InteractionWithPlayer(action,  out string act,
                out string message);
            return RedirectToAction(act, "Game", new { slogan = message });
        }
    }
}