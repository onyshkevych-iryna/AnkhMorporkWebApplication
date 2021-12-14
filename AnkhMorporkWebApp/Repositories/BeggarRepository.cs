using AnkhMorporkWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ApplicationContext ApplicationContext
        {
            get { return Context as ApplicationContext; }
        }
    }
}