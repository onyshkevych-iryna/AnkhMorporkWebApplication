using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Abstracts
{
    public abstract class Guilds <T>
    {
        public abstract Player InteractionWithPlayer(string action,decimal balance, decimal sum);
    }
}
