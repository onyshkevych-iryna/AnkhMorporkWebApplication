using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnkhMorporkWebApp.Models;

namespace AnkhMorporkWebApp
{
    public interface IFoolsGuildWebService
    {
        Player InteractionWithPlayer(string action, decimal sum, decimal balance);
    }
}
