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
            Fool fool = fools[rnd.Next(1, fools.Count)];
            PlayerFoolViewModel pfvm = new PlayerFoolViewModel
            {
                player = _player,
                fool = new Fool
                {
                    Practice = fool.Practice,
                    Fee = fool.Fee
                }
            };
            return pfvm;
        }
    }
}
