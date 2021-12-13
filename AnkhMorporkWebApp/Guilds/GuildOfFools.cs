using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfFools
    {

        public  Player InteractionWithPlayer(string action, decimal balance, int beerAmount, decimal sum)
        {
            Player player = new Player(balance, beerAmount);
            if (action == "Yes")
            {
                player.GetMoney(sum);
            }
            else
            {
                player.Skip(typeof(Fool));
            }
            return player;
        }
    }
}
