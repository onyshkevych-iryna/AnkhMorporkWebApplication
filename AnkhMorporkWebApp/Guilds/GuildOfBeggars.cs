using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfBeggars
    {
        public Player InteractionWithPlayer(out string controller, out string act, out string message, string action, decimal balance = 0, int beerAmount=0, decimal sum=0) {
            Player player = new Player(balance, beerAmount);
            if (action == "Yes")
            {
                if (sum != 0)
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
                        controller = "Game";
                        act = "Index";
                    }
                    message = null;
                }
                else
                {
                    if (beerAmount != 0)
                    {
                        player.BeerAmount--;
                        controller = "Game";
                        act = "Index";
                        message = null;
                    }
                    else
                    {
                        message = player.Skip(typeof(Beggar));
                        controller = "Game";
                        act = "EndOfGame";
                    }
                }
            }
            else
            {
                message = player.Skip(typeof(Beggar));
                controller = "Game";
                act = "EndOfGame";
            }
            return player;
        }


    }
}


