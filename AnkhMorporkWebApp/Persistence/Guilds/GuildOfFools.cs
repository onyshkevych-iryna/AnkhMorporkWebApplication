using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfFools : Guilds<Fool>
    {
        public override Player InteractionWithPlayer(string action, out string act, out string message, decimal balance = 0, int beerAmount = 0, decimal sum = 0)
        {
            var player = new Player(balance, beerAmount);
            if (action == "Yes")
            {
                player.GetMoney(sum);
            }
            else
            {
                player.Skip(typeof(Fool));
            }
            act = "Index";
            message = null;
            return player;
        }
    }
}
