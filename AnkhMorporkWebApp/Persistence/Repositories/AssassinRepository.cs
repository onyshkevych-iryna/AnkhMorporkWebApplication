using System.Collections.Generic;
using System.Linq;
using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp
{
    public class AssassinRepository:Repository<Assassin>,IAssassinRepository
    {
        public AssassinRepository(ApplicationContext context):base(context)
        {

        }
        public IEnumerable<Assassin> GetAllAssassins()
        {
            var guildOfAssassins = Context.Assassins.ToList();
            return guildOfAssassins;
        }
    }
}