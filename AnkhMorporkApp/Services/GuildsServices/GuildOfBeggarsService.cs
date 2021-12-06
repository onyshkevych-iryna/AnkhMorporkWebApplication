using System;
using AnkhMorporkApp.Guilds;
using AnkhMorporkApp.Models;

namespace AnkhMorporkApp.Services.GuildsServices
{
    public class GuildOfBeggarsService
    {
        public Beggar GetRandomBeggar(Random rnd)
        {
            var guildOfBeggars = new GuildOfBeggars();
            var beggars = guildOfBeggars.Beggars;
            return beggars[rnd.Next(1, beggars.Count + 1)];
        }
    }
}
