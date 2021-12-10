using System.Web.Mvc;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class BeggarsGuildController : Controller
    {

        // GET: BeggarssGuild
        public ActionResult Index()
        {
            var model = TempData["NewBeggarModel"] as PlayerBeggarViewModel;
            return View(model);
        }

        public ActionResult Yes(decimal sum, decimal balance)
        {
            Player player = new Player(balance);
            
                player.GiveMoney(sum);
                return RedirectToAction("Index", "Home", player);
            
        }

        public ActionResult No(Player player)
        {

            string message = player.Skip(typeof(Beggar));

            return RedirectToAction("EndOfGame", "Game", new {slogan = message});
        }
    }
}