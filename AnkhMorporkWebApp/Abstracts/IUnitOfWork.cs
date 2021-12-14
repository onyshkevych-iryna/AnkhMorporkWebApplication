using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkWebApp.Abstracts
{
    interface IUnitOfWork:IDisposable
    {
        IAssassinRepository Assassins { get; }
    }
}
