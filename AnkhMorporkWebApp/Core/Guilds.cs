using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Abstracts
{
    public abstract class Guilds <T>
    {
        public abstract Player InteractionWithPlayer(string action, out string act, out string message, decimal balance = 0, int beerAmount = 0,
            decimal sum = 0);
    }
}
