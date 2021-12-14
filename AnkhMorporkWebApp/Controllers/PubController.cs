using System.Web.Mvc;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class PubController : Controller
    {
        public ActionResult Index(Player player)
        {
            var pubViewModel = new PlayerPubViewModel
            {
                Player = player,
                Pub = new Pub()
            };
            return View(pubViewModel);
        }
        
        public ActionResult GetBeer(Player player)
        {
            var pub = new Pub();
            if (player.BeerAmount < pub.MaxAmountOfBeerForPlayer)
            {
                player.BeerAmount++;
                player.Balance -= pub.Price;
            }
            return RedirectToAction("Index",player);
        }
    }
}