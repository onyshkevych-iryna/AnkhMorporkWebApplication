using System;
using System.Web.Mvc;
using AnkhMorporkWebApp.Models;
using Player = AnkhMorporkApp.Models.Player;

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
    }
}