using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkhMorporkWebApp.Models
{
    public class PlayerAssassinViewModel
    {
        public Player player { get; set; }
        public Assassin Assassin { get; set; }
        public decimal amount { get; set; }
        public string slogan { get; set; } = "Someone wants to kill you!";
    }
}