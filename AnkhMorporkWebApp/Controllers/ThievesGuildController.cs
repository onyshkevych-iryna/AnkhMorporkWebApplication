using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class ThievesGuildController : Controller
    {
        private GuildOfThieves guild = new GuildOfThieves();
        private Player player;
        private Thief thief = new Thief();

        public ActionResult Index()
        {
            var model = TempData["NewCustomer"] as PlayerThiefModel;
            --GuildOfThieves.NumberOfThieves;
            return View(model);
        }

        public ActionResult Yes(string action, Player player)
        {
            player = guild.InteractionWithPlayer(action,player.Balance,player.BeerAmount, thief.Fee, out string controller, out string actionName,
                out string message);
            return RedirectToAction(actionName, controller, player);
        }

        public ActionResult No(string action, Player player)
        {
            guild.InteractionWithPlayer(action, 0,0, 0, out string con, out string act,
                out string message);
            return RedirectToAction(act, con, new { slogan = message });
        }
    }
}