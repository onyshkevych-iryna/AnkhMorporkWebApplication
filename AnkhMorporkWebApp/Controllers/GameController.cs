using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        { 
            Player _player = new Player();
        _player.IsAlive = true;

        return RedirectToAction("Index", "Home", _player);
        }

        public ActionResult EndOfGame(string slogan)
        {
            MessageViewModel mvm = new MessageViewModel
            {
                Message = slogan
            };
            return View(mvm);
        }
    }
}