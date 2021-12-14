using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ApplicationContext ApplicationContext
        {
            get{return Context as ApplicationContext;}
        }
    }
}