using System.Collections.Generic;
using System.Linq;
using AnkhMorporkWebApp.Abstracts;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp
{
    public class FoolRepository : Repository<Fool>, IFoolRepository
    {
        public FoolRepository(ApplicationContext context) : base(context)
        {

        }
        public List<Fool> GetAllFools()
        {
            var guildOfFools = Context.Fools.ToList();
            return guildOfFools;
        }
    }
}