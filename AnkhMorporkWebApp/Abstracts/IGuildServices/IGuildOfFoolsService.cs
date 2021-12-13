using System;
using AnkhMorporkApp.Models;

namespace AnkhMorporkApp.Abstracts.IGuildServices
{
    interface IGuildOfFoolsService
    {
        void FoolMeetsPlayer(Random rnd, PlayerDTO player);
    }
}
