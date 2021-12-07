using System.Web.Mvc;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class FoolsGuildController : Controller
    {

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

        public ActionResult No(Player player)
        {

            string message = player.Skip(typeof(Fool));


            return RedirectToAction("Index", "Home", player );
        }

        //public ActionResult Reject(string slogan, decimal amount)
        //{
        //    Player _player = new Player(amount);
        //    MessageViewModel mvm = new MessageViewModel
        //    {
        //        Message = slogan,
        //        player = _player
        //    };

        //    return View(mvm);
        //}

    }
}