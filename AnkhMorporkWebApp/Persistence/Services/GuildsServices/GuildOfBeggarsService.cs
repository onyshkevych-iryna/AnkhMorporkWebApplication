using System;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfBeggarsService
    {
        public PlayerBeggarViewModel GetRandomBeggar(Player player, Random rnd)
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationContext()))
            {
                var beggars = unitOfWork.Beggars.GetAllBeggars();
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
}
