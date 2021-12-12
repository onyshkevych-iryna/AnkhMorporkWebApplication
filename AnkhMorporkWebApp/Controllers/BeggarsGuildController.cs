using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class BeggarsGuildController : Controller
    {
        private GuildOfBeggars guild = new GuildOfBeggars();
        private Player player;

        public ActionResult Index()
        {
            var model = TempData["NewBeggarModel"] as PlayerBeggarViewModel;
            return View(model);
        }

        public ActionResult Yes(string action, int beerAmount, decimal balance, decimal fee)
        {
            player = guild.InteractionWithPlayer(action, balance, beerAmount, fee, out string controller, out string actionName,
                out string message);
            return RedirectToAction(actionName, controller, player);
        }

        public ActionResult No(string action, Player player)
        {
            guild.InteractionWithPlayer(action, 0, 0, 0, out string con, out string act,
                out string message);
            return RedirectToAction(act, con, new { slogan = message });
        }
    }
}