using System;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Core
{
    interface IPlayerViewModelBuilder
    {
        PlayerBeggarViewModel GetPlayerBeggarViewModel(Player player, Beggar beggar);
        PlayerFoolViewModel GetPlayerFoolViewModel(Player player, Fool fool);
        PlayerThiefViewModel GetPlayerThiefViewModel(Player player);
    }
}
