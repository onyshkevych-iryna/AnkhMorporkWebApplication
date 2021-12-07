using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkhMorporkWebApp.Models
{
    public class MessageViewModel
    {
        public string Message { get; set; }
        public Player player { get; set; }
    }
}