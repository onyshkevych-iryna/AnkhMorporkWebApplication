using AnkhMorporkApp.Models;

namespace AnkhMorporkApp.Abstracts
{
    public abstract class Guilds <T>
    {
        public abstract void InteractionWithPlayer(Player player, T guildMember);
    }
}
