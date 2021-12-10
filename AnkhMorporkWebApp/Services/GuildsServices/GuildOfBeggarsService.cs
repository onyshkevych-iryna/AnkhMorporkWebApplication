using System;
using System.Linq;
using AnkhMorporkApp.Guilds;
using AnkhMorporkWebApp;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfBeggarsService
    {
        private ApplicationContext db = new ApplicationContext();

        public Beggar GetRandomBeggar(Random rnd)
        {
            var beggars = db.Beggars.ToList();
            return beggars[rnd.Next(1, beggars.Count + 1)];
        }
    }
}
