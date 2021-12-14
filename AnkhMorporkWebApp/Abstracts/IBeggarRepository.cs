using System.Collections.Generic;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp.Abstracts
{
    public interface IBeggarRepository : IRepository<Beggar>
    {
        List<Beggar> GetAllBeggars();
    }
}
