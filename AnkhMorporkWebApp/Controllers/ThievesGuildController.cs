using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class ThievesGuildController : Controller
    {
        private readonly GuildOfThieves _guild = new GuildOfThieves();
        private Thief _thief = new Thief();

        public ActionResult Index()
        {
            var model = TempData["ThiefViewModel"] as PlayerThiefViewModel;
            --GuildOfThieves.NumberOfThieves;
            return View(model);
        }

        public ActionResult Yes(string action, Player player)
        {
            player = _guild.InteractionWithPlayer(action, out string actionName,
                out string message, player.Balance, player.BeerAmount, _thief.Fee);
            return RedirectToAction(actionName, "Game", player);
        }

        public ActionResult No(string action)
        {
            _guild.InteractionWithPlayer(action, out string act,
                out string message);
            return RedirectToAction(act, "Game", new { slogan = message });
        }
    }
}