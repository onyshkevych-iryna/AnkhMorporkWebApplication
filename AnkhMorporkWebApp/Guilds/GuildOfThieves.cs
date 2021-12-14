using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfThieves : Guilds<Thief>
    {
        public static int NumberOfThieves = 6;
        public override Player InteractionWithPlayer(string action, out string controller, out string act, out string message, decimal balance=0, int beerAmount=0, decimal sum=0)
        { 
            var player = new Player(balance, beerAmount);
            if (action == "Yes")
            {
                var isValid = false;
                player.GiveMoney(sum, ref isValid);
                if (!isValid)
                {
                    controller = "Game";
                    act = "EndOfGame";
                }
                else
                {
                    controller = "Game";
                    act = "Index";
                }
                message = null;
            }
            else
            {
                message = player.Skip(typeof(Thief));
                controller = "Game";
                act = "EndOfGame";
            }
            return player;
        }
    }
}
