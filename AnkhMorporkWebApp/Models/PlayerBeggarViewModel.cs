using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkhMorporkWebApp.Models
{
    public class PlayerBeggarViewModel
    {
        public Player player { get; set; }
        public Beggar begar { get; set; }
        public string slogan { get; set; } = "You met a beggar!";
    }
}