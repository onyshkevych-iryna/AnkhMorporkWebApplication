using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Guilds
{
    public class GuildOfBeggars
    {
        public List<Beggar> Beggars;


        //public override void InteractionWithPlayer(Player player, Beggar beggar)
        //{
        //    if (beggar.Fee != 0)
        //    {
        //        //ConsoleColorChanger.ChangeColor($"You came across a beggar! To pay him {CurrencyConverter.Convert(beggar.Fee)} - enter \"yes\". To skip - enter \"no\".", ConsoleColor.Green);
        //        if (player.IsOutOfMoney(beggar.Fee))
        //        {
        //            return;
        //        }
        //        var validInput = false;
        //        do
        //        {
        //            var input = Console.ReadLine();
        //            if (input == "yes")
        //            {
        //               // player.GiveMoney(beggar.Fee, ref validInput);
        //            }
        //            else if (input == "no")
        //            {
        //                player.Skip(beggar.GetType());
        //                return;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Incorrect data! Please, try again:");
        //            }
        //        } while (!validInput);
        //    }
        //    //else
        //    //    ConsoleColorChanger.ChangeColor("You met people with placards saying: \"Why lie? I need a beer\".", ConsoleColor.Yellow);
        //}

        public Player InteractionWithPlayer(string action, decimal balance, int beerAmount, decimal sum,
            out string controller, out string act, out string message)
        {
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
                        controller = "Home";
                        act = "Index";
                    }
                    message = null;
                }
                else
                {
                    if (beerAmount != 0)
                    {
                        player.BeerAmount--;
                        controller = "Home";
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


