using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class FoolsGuildController : Controller
    {
        private readonly GuildOfFools _guild = new GuildOfFools();
        private Player _player;

        public ActionResult Index()
        {
            var model = TempData["FoolViewModel"] as PlayerFoolViewModel;
            return View(model);
        }

        public ActionResult Yes(string action, decimal balance, int beerAmount, decimal sum)
        {
            _player = _guild.InteractionWithPlayer(action, out string controller, out string act, out string message, balance,  beerAmount,  sum);
            return RedirectToAction(act, controller, _player);
        }

        public ActionResult No(string action, Player player)
        {
            player = _guild.InteractionWithPlayer(action, out string controller, out string act, out string message, player.Balance, player.BeerAmount, 0);
            return RedirectToAction(act, controller, player );
        }
    }
}