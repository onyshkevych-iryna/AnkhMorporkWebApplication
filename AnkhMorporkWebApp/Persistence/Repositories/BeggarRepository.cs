using AnkhMorporkWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using AnkhMorporkWebApp.Abstracts;

namespace AnkhMorporkWebApp
{
    public class BeggarRepository : Repository<Beggar>, IBeggarRepository
    {
        public BeggarRepository(ApplicationContext context) : base(context)
        {

        }
        public List<Beggar> GetAllBeggars()
        {
            var guildOfBeggars = Context.Beggars.ToList();
            return guildOfBeggars;
        }
    }
}