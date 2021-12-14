using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Abstracts
{
    public interface IAssassinRepository:IRepository<Assassin>
    {
        IEnumerable<Assassin> GetAllAssassins();
    }
}
