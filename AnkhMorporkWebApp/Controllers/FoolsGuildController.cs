using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class FoolsGuildController : Controller
    {
        private GuildOfFools guild = new GuildOfFools();
        private Player player;

        public ActionResult Index()
        {
            var model = TempData["NewFoolModel"] as PlayerFoolViewModel;
            return View(model);
        }

        public ActionResult Yes(string action, decimal balance, int beerAmount, decimal sum)
        {
            player = guild.InteractionWithPlayer(action, balance,  beerAmount,  sum);
            return RedirectToAction("Index", "Game", player);
        }

        public ActionResult No(string action, Player player)
        {
            player = guild.InteractionWithPlayer(action, player.Balance, player.BeerAmount, 0);
            return RedirectToAction("Index", "Game", player );
        }
    }
}