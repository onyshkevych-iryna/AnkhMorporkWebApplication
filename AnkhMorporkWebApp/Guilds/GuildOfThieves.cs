using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfThieves 
    {
        public static int NumberOfThieves = 6;
        public  Player InteractionWithPlayer(string action, decimal balance, int beerAmount, decimal sum, out string controller, out string act, out string message)
        { 
            Player player = new Player(balance, beerAmount);
            if (action == "Yes")
            {
                bool isValid = false;
                player.GiveMoney(sum, ref isValid);
                if (!isValid)
                {
                    controller = "Game";
                    act = "EndOfGame";
                }
                else
                {
                    controller = "Home";
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
