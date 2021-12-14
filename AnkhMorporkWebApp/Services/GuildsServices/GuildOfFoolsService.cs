using System;
using System.Linq;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfFoolsService
    {
        private ApplicationContext db = new ApplicationContext();

        public PlayerFoolViewModel GetRandomFool(Player _player, Random rnd)
        {
            var fools = db.Fools.ToList();
            var fool = fools[rnd.Next(1, fools.Count)];
            var foolViewModel = new PlayerFoolViewModel
            {
                Player = _player,
                Fool = new Fool
                {
                    Practice = fool.Practice,
                    Fee = fool.Fee
                }
            };
            return foolViewModel;
        }
    }
}
