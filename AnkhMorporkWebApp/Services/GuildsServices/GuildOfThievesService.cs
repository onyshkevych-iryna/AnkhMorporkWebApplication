using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfThievesService
    {
        public PlayerThiefModel GetThieve(Player _player)
        {
            PlayerThiefModel ptm = new PlayerThiefModel
            {
                player = _player,
                thief = new Thief()
            };
            return ptm;
        }
    }
}