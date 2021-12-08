using AnkhMorporkApp.Abstracts;
using AnkhMorporkApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkApp.Guilds
{
    public class GuildOfFools : Guilds<Fool>
    {
        public List<Fool> Fools;

        //public Dictionary<int, Fool> Fools;

        //public GuildOfFools()
        //{
        //    Fools = new Dictionary<int, Fool>()   {
        //        { 1, new Fool("Muggins", 5)},
        //        { 2, new Fool( "Gull", 1  )},
        //        { 3, new Fool( "Dupe", 2 )},
        //        { 4, new Fool("Butt", 3 )},
        //        { 5, new Fool( "Fool", 5 )},
        //        { 6, new Fool( "Tomfool", 6 )},
        //        { 7, new Fool( "Stupid Fool", 7 )},
        //        { 8, new Fool( "Arch Fool", 8 )},
        //        { 9, new Fool( "Complete Fool", 10 )}
        //    };

        //}

        public override void InteractionWithPlayer(Player player, Fool fool)
        {
            //ConsoleColorChanger.ChangeColor($"You came across a friend!\nTo join their offer to work as {fool.Practice} " +
                                 //           $"and earn {CurrencyConverter.Convert(fool.Fee)} - enter \"yes\". To skip - enter \"no\".", ConsoleColor.Green);
            var validInput = false;
            do
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "yes":
                        player.GetMoney(fool.Fee, ref validInput);
                        break;
                    case "no":
                        player.Skip(fool.GetType());
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please, try again:");
                        break;
                }
            } while (!validInput);
        }
    }
}
