using System;
using System.Linq;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Services.GuildsServices
{
    public class GuildOfFoolsService
    {
        private ApplicationContext db = new ApplicationContext();

        public PlayerFoolViewModel GetRandomFool(Player _player, Random rnd)
        {
            using (var unitOfWork = new UnitOfWork(new ApplicationContext()))
            {
                var fools = unitOfWork.Fools.GetAllFools();
                var fool = fools[rnd.Next(1, fools.Count)];
                var foolViewModel = new PlayerFoolViewModel
                {
                    Player = _player,
                    Fool = new Fool
                    {
                        Practice = fool.Practice,
                        Fee = fool.Fee
                    }
                };
                return foolViewModel;
            }
        }
    }
}
