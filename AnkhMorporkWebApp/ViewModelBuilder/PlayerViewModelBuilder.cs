using AnkhMorporkWebApp.Core;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.ViewModelBuilder
{
    public class PlayerViewModelBuilder: IPlayerViewModelBuilder
    {
        public  PlayerBeggarViewModel GetPlayerBeggarViewModel(Player player, Beggar beggar)
        {
            var beggarViewModel = new PlayerBeggarViewModel
                {
                    Player = player,
                    Beggar = new Beggar
                    {
                        Practice = beggar.Practice,
                        Fee = beggar.Fee
                    }
                };
                return beggarViewModel;
        }

        public  PlayerFoolViewModel GetPlayerFoolViewModel(Player player, Fool fool)
        {
            var foolViewModel = new PlayerFoolViewModel
                    {
                        Player = player,
                        Fool = new Fool
                        {
                            Practice = fool.Practice,
                            Fee = fool.Fee
                        }
                    }; 
            return foolViewModel;
        }

        public  PlayerThiefViewModel GetPlayerThiefViewModel(Player player)
        {
            var thiefViewModel = new PlayerThiefViewModel
                {
                    Player = player,
                    Thief = new Thief()
                }; 
            return thiefViewModel;
        }
    }
}