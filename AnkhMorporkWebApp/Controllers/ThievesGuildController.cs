﻿using System.Web.Mvc;
using AnkhMorporkApp.Guilds;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class ThievesGuildController : Controller
    {
        public ActionResult Index()
        {
            var model = TempData["NewCustomer"] as PlayerThiefModel;
            --GuildOfThieves.NumberOfThieves;
            return View(model);
        }

        public ActionResult Yes(decimal sum, decimal balance)
        {
            Player player = new Player(balance);
            if (player.IsOutOfMoney(sum))
                return RedirectToAction("EndOfGame", "Game");
            player.GiveMoney(sum);
            return RedirectToAction("Index", "Home", player);
        }

        public ActionResult No(Player player)
        {
            string message = player.Skip(typeof(Thief));
            return RedirectToAction("EndOfGame", "Game", new { slogan = message });
        }
    }
}