using System.Linq;
using System.Web.Mvc;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Controllers
{
    public class AssassinsGuildController : Controller
    {
        private ApplicationContext db = new ApplicationContext();
        private Player _player;

        public ActionResult Skip(Player player)
        {
            string message = player.Skip(typeof(Assassin));
            return RedirectToAction("EndOfGame", "Game", new {slogan = message});
        }

        public ActionResult About(decimal amount)
        {
            _player = new Player(amount);
            PlayerAssassinViewModel pavm = new PlayerAssassinViewModel();
            pavm.player = _player;
            return View(pavm);
        }

        public ActionResult Input(PlayerAssassinViewModel vm)
        {
            //if (vm.player.IsOutOfMoney(vm.player.Balance))
            //    return RedirectToAction("EndOfGame", "Game");

            var guildOfAssassins = db.Assassins.ToList();
            var assassin = guildOfAssassins
                .FirstOrDefault(a => a.MinReward <= vm.amount && a.MaxReward >= vm.amount && !a.IsOccupied);
            vm.player.GiveMoney(vm.amount);
            if(vm.player.IsAlive==false)
                  return RedirectToAction("EndOfGame", "Game");
            _player = new Player(vm.player.Balance);
            return RedirectToAction("Index", "Home", _player);
        }

        public ActionResult Question()
        {
            var model = TempData["NewAssassinModel"] as PlayerAssassinViewModel;
            return View(model);
        }
    }
}