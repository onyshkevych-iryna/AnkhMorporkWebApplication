using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnkhMorporkWebApp.Abstracts;

namespace AnkhMorporkWebApp
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Assassins = new AssassinRepository(_context);
        }
        public IAssassinRepository Assassins { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}