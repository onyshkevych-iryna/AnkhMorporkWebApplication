using System.Web.Mvc;
using AnkhMorporkWebApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class BeggarsGuildController : Controller
    {
        private readonly GuildOfBeggars _guild = new GuildOfBeggars();
        private Player player;

        public ActionResult Index()
        {
            var model = TempData["BeggarViewModel"] as PlayerBeggarViewModel;
            return View(model);
        }

        public ActionResult Yes(string action, int beerAmount, decimal balance, decimal fee)
        {
            player = _guild.InteractionWithPlayer(out string controller, out string actionName,
                out string message, action, balance, beerAmount, fee);
            return RedirectToAction(actionName, controller, player);
        }

        public ActionResult No(string action)
        {
            _guild.InteractionWithPlayer(out string controller, out string actionName,
                out string message, action);
            return RedirectToAction(actionName, controller, new { slogan = message });
        }
    }
}