using System.Collections.Generic;

namespace AnkhMorporkWebApp.Abstracts
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
    }
}
