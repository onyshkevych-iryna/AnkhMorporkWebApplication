using System;
using AnkhMorporkApp.Models;

namespace AnkhMorporkApp.Abstracts.IGuildServices
{
    interface IGuildOfThievesService
    {
        void ThiefMeetsPlayer(Random rnd, PlayerDTO player);
    }
}
