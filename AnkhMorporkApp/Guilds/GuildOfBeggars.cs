﻿using System;
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
