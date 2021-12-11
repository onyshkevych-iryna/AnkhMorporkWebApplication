using System.Web.Mvc;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class BeggarsGuildController : Controller
    {
        public ActionResult Index()
        {
            var model = TempData["NewBeggarModel"] as PlayerBeggarViewModel;
            return View(model);
        }

        public ActionResult Yes(decimal balance, decimal fee)
        {
            Player player = new Player(balance);
            if (fee != 0)
            {
                if (player.IsOutOfMoney(fee))
                    return RedirectToAction("EndOfGame", "Game");
                player.GiveMoney(fee);
            }
            else
            {
                if(player.BeerAmount!=0) 
                    player.BeerAmount--;
                else
                {
                    string message = player.Skip(typeof(Beggar));
                    return RedirectToAction("EndOfGame", "Game", new { slogan = message });
                }
            }
            return RedirectToAction("Index", "Home", player);
        }

        public ActionResult No(Player player)
        {
            string message = player.Skip(typeof(Beggar));
            return RedirectToAction("EndOfGame", "Game", new {slogan = message});
        }
    }
}