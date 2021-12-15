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
            Beggars = new BeggarRepository(_context);
            Fools = new FoolRepository(_context);
        }
        public IAssassinRepository Assassins { get; private set; }
        public IBeggarRepository Beggars { get; private set; }
        public IFoolRepository Fools { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}