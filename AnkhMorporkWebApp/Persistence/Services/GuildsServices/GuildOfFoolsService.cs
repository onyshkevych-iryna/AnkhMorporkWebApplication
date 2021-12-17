using System;
using AnkhMorporkWebApp.Core;
using AnkhMorporkWebApp.Models;
using AnkhMorporkWebApp.ViewModelBuilder;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfFoolsService
    {
        public PlayerFoolViewModel GetRandomFool(Player player, Random rnd)
        {
            IPlayerViewModelBuilder viewModelBuilder = new PlayerViewModelBuilder();
            using (var unitOfWork = new UnitOfWork(new ApplicationContext()))
            {
                var fools = unitOfWork.Fools.GetAllFools();
                var fool = fools[rnd.Next(1, fools.Count)];
                return viewModelBuilder.GetPlayerFoolViewModel(player, fool);
            }
        }
    }
}
