using System.Web.Mvc;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class PubController : Controller
    {
        public ActionResult Index(Player player)
        {
            PlayerPubViewModel pbvm = new PlayerPubViewModel
            {
                player = player,
                pub = new Pub()
            };
            return View(pbvm);
        }
        
        public ActionResult GetBeer(Player player)
        {
            Pub pub = new Pub();
            if (player.BeerAmount < pub.MaxAmountOfBeerForPlayer)
            {
                player.BeerAmount++;
                player.Balance -= pub.Price;
            }
            return RedirectToAction("Index",player);
        }
    }
}