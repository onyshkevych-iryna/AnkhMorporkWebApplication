using AnkhMorporkWebApp.Core;
using AnkhMorporkWebApp.Models;
using AnkhMorporkWebApp.ViewModelBuilder;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfThievesService
    {
        public PlayerThiefViewModel GetThieve(Player player)
        {
            IPlayerViewModelBuilder viewModelBuilder = new PlayerViewModelBuilder();
            return viewModelBuilder.GetPlayerThiefViewModel(player);
        }
    }
}