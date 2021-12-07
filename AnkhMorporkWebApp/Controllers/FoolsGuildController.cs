using System.Web.Mvc;
using AnkhMorporkWebApp.Models;
using Fool = AnkhMorporkApp.Models.Fool;

namespace AnkhMorporkWebApp.Controllers
{
    public class FoolsGuildController : Controller
    {
        // GET: FoolsGuild
        public ActionResult Index()
        {
            var model = TempData["NewFoolModel"] as PlayerFoolViewModel;
            return View(model);
        }

        public ActionResult Yes(decimal sum, decimal balance)
        {
            Player player = new Player(balance);
            player.GetMoney(sum);
            return RedirectToAction("Index", "Home", player);
        }
    }
}