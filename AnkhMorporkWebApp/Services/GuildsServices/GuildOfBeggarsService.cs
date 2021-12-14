using System;
using System.Linq;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfBeggarsService
    {
        private ApplicationContext db = new ApplicationContext();

        public PlayerBeggarViewModel GetRandomBeggar(Player player, Random rnd)
        {
            var beggars = db.Beggars.ToList();
            var beggar = beggars[rnd.Next(1, beggars.Count)];
            var beggarViewModel = new PlayerBeggarViewModel
            {
                Player = player,
                Beggar = new Beggar
                {
                    Practice = beggar.Practice,
                    Fee = beggar.Fee
                }
            };
            return beggarViewModel;
        }
    }
}
