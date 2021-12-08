using AnkhMorporkWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkhMorporkWebApp
{
    public class GuildsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            var assassins = new List<Assassin>
            {
                new Assassin { Name = "Assassin1", MinReward = 15, MaxReward = 30, IsOccupied = true},
                new Assassin {Name = "Assassin2", MinReward = 10, MaxReward = 20, IsOccupied = false},
                new Assassin {Name = "Assassin3", MinReward = 7, MaxReward = 12, IsOccupied = true},
                new Assassin {Name = "Assassin4", MinReward = 15, MaxReward = 19, IsOccupied = false},
            };

            assassins.ForEach(s => context.Assassins.Add(s));
            context.SaveChanges();
            var beggars = new List<Beggar>
            {

                new Beggar {Practice = "Twitchers", Fee = 3},
                new Beggar {Practice = "Droolers", Fee = 2},
                new Beggar {Practice = "Dribblers", Fee = 1},
                new Beggar {Practice = "Mumblers", Fee = 1},
                new Beggar {Practice = "Mutterers", Fee = 0.9m},
                new Beggar {Practice = "Walking-Along-Shouter", Fee = 0.8m},
                new Beggar {Practice = "Demanders of a Chip", Fee = 0.6m},
                new Beggar {Practice = "People Who Call Other People Jimmy", Fee = 0.5m},
                new Beggar {Practice = "People Who Need Eightpence For A Meal", Fee = 0.08m},
                new Beggar {Practice = "People Who Need Tuppence For A Cup Of Tea", Fee = 0.02m},
                new Beggar {Practice = "People Who Need Tuppence For A Cup Of Tea", Fee = 0.02m}
            };
            beggars.ForEach(s => context.Beggars.Add(s));
            context.SaveChanges();

            var fools = new List<Fool>
            {
                new Fool {Practice = "Muggins", Fee = 5},
                new Fool {Practice = "Gull", Fee = 1},
                new Fool {Practice = "Dupe", Fee = 2},
                new Fool {Practice = "Dupe", Fee = 3},
                new Fool {Practice = "Fool", Fee = 5},
                new Fool {Practice = "Tomfool", Fee = 6},
                new Fool {Practice = "Stupid Fool", Fee = 7},
                new Fool {Practice = "Arch Fool", Fee = 8},
                new Fool {Practice = "Complete Fool", Fee = 10}
            };

            fools.ForEach(s => context.Fools.Add(s));
            context.SaveChanges();
        }
    }
}