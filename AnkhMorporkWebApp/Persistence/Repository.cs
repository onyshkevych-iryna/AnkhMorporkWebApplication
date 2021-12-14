using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnkhMorporkWebApp.Abstracts;

namespace AnkhMorporkWebApp
{
    public class Repository<TEntity>:IRepository<TEntity> where TEntity:class
    {
        protected readonly ApplicationContext Context;

        public Repository(ApplicationContext context)
        {
            Context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

    }
}