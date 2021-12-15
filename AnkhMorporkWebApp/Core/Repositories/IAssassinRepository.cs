using System.Collections.Generic;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Abstracts
{
    public interface IAssassinRepository:IRepository<Assassin>
    {
        IEnumerable<Assassin> GetAllAssassins();
    }
}
