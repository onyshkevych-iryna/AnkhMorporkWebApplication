
using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfAssassins: Guilds<Assassin>
    {



        //public override void InteractionWithPlayer(Player player, List<Assassin> assassins)
        //{
        //    //ConsoleColorChanger.ChangeColor(
        //    //    "Someone wants to kill you!\nEnter sum of money to make a contract with an assassin. Or enter \"no\" to skip.",
        //    //    ConsoleColor.Green);
        //    var validInput = false;
        //    do
        //    {
        //        var input = Console.ReadLine();
        //        if (input == "no")
        //        {
        //            player.Skip(typeof(Assassin));
        //            return;
        //        }

        //        //if (!Decimal.TryParse(input, out var amount))
        //        //{
        //        //    Console.WriteLine("Incorrect data! Try again:");
        //        //    continue;
        //        //}

        //        //if (!player.EnteredSumIsCorrect(amount))
        //        //{
        //        //    continue;
        //        //}

        //        //var assassin = assassins
        //        //    .FirstOrDefault(a => a.MinReward <= amount && a.MaxReward >= amount && !a.IsOccupied);
        //        //if (assassin!=null)
        //        //{
        //        //    Console.WriteLine($"Assassin \"{assassin.Name}\" made a contract with you!");
        //        //    player.GiveMoney(amount, ref validInput);
        //        //}
        //        //else
        //        //{
        //        //    //ConsoleColorChanger.ChangeColor("There is no opportunity to make a contract! Game is over",
        //        //    //    ConsoleColor.Red);
        //        //    player.IsAlive = false;
        //        //    return;
        //        //}
        //    } while (!validInput);
        public override Player InteractionWithPlayer(string action, decimal balance, decimal sum)
        {
            Player player = new Player(balance);
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
