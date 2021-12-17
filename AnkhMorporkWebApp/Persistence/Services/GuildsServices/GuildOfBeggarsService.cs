using System;
using AnkhMorporkWebApp.Core;
using AnkhMorporkWebApp.Models;
using AnkhMorporkWebApp.ViewModelBuilder;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfBeggarsService
    {
        public PlayerBeggarViewModel GetRandomBeggar(Player player, Random rnd)
        {
            IPlayerViewModelBuilder viewModelBuilder = new PlayerViewModelBuilder();
            using (var unitOfWork = new UnitOfWork(new ApplicationContext()))
            {
                var beggars = unitOfWork.Beggars.GetAllBeggars();
                var beggar = beggars[rnd.Next(1, beggars.Count)];
                return viewModelBuilder.GetPlayerBeggarViewModel(player, beggar);
            }
        }
    }
}
