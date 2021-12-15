using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfBeggars : Guilds<Beggar>
    {
        public override Player InteractionWithPlayer(string action, out string act, out string message, decimal balance = 0, int beerAmount=0, decimal sum=0) {
            var player = new Player(balance, beerAmount);
            if (action == "Yes")
            {
                if (sum != 0)
                {
                    var isValid = false;
                    player.GiveMoney(sum, ref isValid);
                    if (!isValid)
                    {
                        act = "EndOfGame";
                    }
                    else
                    {
                        act = "Index";
                    }
                    message = null;
                }
                else
                {
                    if (beerAmount != 0)
                    {
                        player.BeerAmount--;
                        act = "Index";
                        message = null;
                    }
                    else
                    {
                        message = player.Skip(typeof(Beggar));
                        act = "EndOfGame";
                    }
                }
            }
            else
            {
                message = player.Skip(typeof(Beggar));
                act = "EndOfGame";
            }
            return player;
        }


    }
}


