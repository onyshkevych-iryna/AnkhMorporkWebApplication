using System;
using AnkhMorporkApp.Guilds;
using AnkhMorporkApp.Models;

namespace AnkhMorporkApp.Services.GuildsServices
{
    public class GuildOfFoolsService
    {
        public Fool GetRandomFool(Random rnd)
        {
            var guildOfFools = new GuildOfFools();
            var fools = guildOfFools.Fools;
            return fools[rnd.Next(1, fools.Count + 1)];
        }
    }
}
