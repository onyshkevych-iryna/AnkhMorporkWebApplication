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
            Beggar rBeggar = beggars[rnd.Next(1, beggars.Count)];
            PlayerBeggarViewModel pbvm = new PlayerBeggarViewModel
            {
                player = player,
                begar = new Beggar
                {
                    Practice = rBeggar.Practice,
                    Fee = rBeggar.Fee
                }
            };
            return pbvm;
        }
    }
}
