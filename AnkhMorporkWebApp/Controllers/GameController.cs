﻿using System;
using System.Web.Mvc;
using AnkhMorporkWebApp.Models;
using AnkhMorporkWebApp.Services.GuildsServices;

namespace AnkhMorporkWebApp.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Start()
        {
            Player _player = new Player();
            _player.IsAlive = true;
            return RedirectToAction("Index", "Game", _player);
        }

        private GuildOfBeggarsService _beggarService = new GuildOfBeggarsService();
        private GuildOfFoolsService _foolService = new GuildOfFoolsService();
        private GuildOfThievesService _thiefservice = new GuildOfThievesService();

        public ActionResult Index(Player _player)
        {
            const int _maxNumberOfGuilds = 3;
            var rnd = new Random();
            var random = rnd.Next(0, _maxNumberOfGuilds);
            if (_player.IsAlive)
            {
                switch (random)
                {
                    case 0:
                        TempData["NewFoolModel"] = _foolService.GetRandomFool(_player, rnd);
                        return RedirectToAction("Index", "FoolsGuild");
                    case 1:
                        TempData["NewBeggarModel"] = _beggarService.GetRandomBeggar(_player, rnd);
                        return RedirectToAction("Index", "BeggarsGuild");
                    case 2:
                        TempData["NewCustomer"] = _thiefservice.GetThieve(_player);
                        return RedirectToAction("Index", "ThievesGuild");
                    case 3:
                        PlayerAssassinViewModel pavm = new PlayerAssassinViewModel();
                        pavm.player = _player;
                        TempData["NewAssassinModel"] = pavm;
                        return RedirectToAction("Question", "AssassinsGuild");
                }
            }
            return RedirectToAction("EndOfGame", "Game");
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