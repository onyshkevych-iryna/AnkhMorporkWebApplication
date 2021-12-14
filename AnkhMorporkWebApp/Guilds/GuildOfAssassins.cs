using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;
using System.Linq;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfAssassins : Guilds<Assassin>
    {
        private ApplicationContext db = new ApplicationContext();
        
        public override Player InteractionWithPlayer(string action,
            out string controller, out string act, out string message, decimal balance=0, int beerAmount=0, decimal sum=0)
        {
            var player = new Player(balance, beerAmount);
            if (action == "Yes")
            {
                var guildOfAssassins = db.Assassins.ToList();
                var assassin = guildOfAssassins
                    .FirstOrDefault(a => a.MinReward <= sum && a.MaxReward >= sum && !a.IsOccupied);
                if (assassin is null)
                {
                    message = player.Skip(typeof(Assassin));
                    controller = "Game";
                    act = "EndOfGame";
                }
                else
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
            }
            else
            {
                message = player.Skip(typeof(Assassin));
                controller = "Game";
                act = "EndOfGame";
            }
            return player;
        }

    }
}
