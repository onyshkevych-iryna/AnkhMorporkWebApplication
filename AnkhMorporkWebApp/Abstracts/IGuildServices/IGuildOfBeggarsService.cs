using System;
using AnkhMorporkApp.Models;

namespace AnkhMorporkApp.Abstracts.IGuildServices
{
    interface IGuildOfBeggarsService
    {
        void BeggarMeetsPlayer(Random rnd, PlayerDTO player);
    }
}
