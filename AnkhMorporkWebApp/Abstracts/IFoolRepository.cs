using AnkhMorporkWebApp.Models;
using System.Collections.Generic;

namespace AnkhMorporkWebApp.Abstracts
{
    public interface IFoolRepository : IRepository<Fool>
    {
        List<Fool> GetAllFools();
    }
}
