using System;

namespace AnkhMorporkWebApp.Abstracts
{
    interface IUnitOfWork:IDisposable
    {
        IAssassinRepository Assassins { get; }
    }
}
