using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnkhMorporkApp.Abstracts;
using AnkhMorporkApp.Models;

namespace AnkhMorporkApp.Guilds
{
    public class GuildOfBeggars : Guilds<Beggar>
    {
        public Dictionary<int, Beggar> Beggars;

        public GuildOfBeggars()
        {
            Beggars = new Dictionary<int, Beggar>()
            {
                { 1, new Beggar( "Twitchers", 3 )},
                { 2, new Beggar("Droolers", 2 )},
                { 3, new Beggar("Dribblers", 1 )},
                { 4, new Beggar("Mumblers", 1 )},
                { 5, new Beggar("Mutterers", 0.9m )},
                { 6, new Beggar("Walking-Along-Shouter", 0.8m )},
                { 7, new Beggar("Demanders of a Chip", 0.6m )},
                { 8, new Beggar("People Who Call Other People Jimmy", 0.5m )},
                { 9, new Beggar("People Who Need Eightpence For A Meal", 0.08m )},
                { 10,new Beggar( "People Who Need Tuppence For A Cup Of Tea", 0.02m)},
                { 11,new Beggar("People Who Need Tuppence For A Cup Of Tea", 0.02m )}
            };
        }

        public override void InteractionWithPlayer(Player player, Beggar beggar)
        {
            if (beggar.Fee != 0)
            {
                //ConsoleColorChanger.ChangeColor($"You came across a beggar! To pay him {CurrencyConverter.Convert(beggar.Fee)} - enter \"yes\". To skip - enter \"no\".", ConsoleColor.Green);
                if (player.IsOutOfMoney(beggar.Fee))
                {
                    return;
                }
                var validInput = false;
                do
                {
                    var input = Console.ReadLine();
                    if (input == "yes")
                    {
                        player.GiveMoney(beggar.Fee, ref validInput);
                    }
                    else if (input == "no")
                    {
                        player.Skip(beggar.GetType());
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect data! Please, try again:");
                    }
                } while (!validInput);
            }
            //else
            //    ConsoleColorChanger.ChangeColor("You met people with placards saying: \"Why lie? I need a beer\".", ConsoleColor.Yellow);
        }
    }
}
