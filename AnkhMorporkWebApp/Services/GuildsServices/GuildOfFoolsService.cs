using System;
using System.Linq;
using AnkhMorporkWebApp;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfFoolsService
    {
        private ApplicationContext db = new ApplicationContext();

        public Fool GetRandomFool(Random rnd)
        {
            //var guildOfFools = new GuildOfFools();
            var fools = db.Fools.ToList();
            return fools[rnd.Next(1, fools.Count)];
        }
    }
}
