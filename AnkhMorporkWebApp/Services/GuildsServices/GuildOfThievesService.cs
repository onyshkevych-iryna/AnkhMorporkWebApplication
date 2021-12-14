using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfThievesService
    {
        public PlayerThiefViewModel GetThieve(Player _player)
        {
            var thiefViewModel = new PlayerThiefViewModel
            {
                Player = _player,
                Thief = new Thief()
            };
            return thiefViewModel;
        }
    }
}