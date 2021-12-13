using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Foolproof;

namespace AnkhMorporkWebApp.Models
{
    public class PlayerAssassinViewModel
    {
        public Player player { get; set; }
        public Assassin Assassin { get; set; }
        public decimal balanceOfPlayer { get; set; }
        //[Required(ErrorMessage = "Amount is required!")]
        [Required]
        public decimal amount { get; set; }
        public string sloganStart { get; set; } = "Someone wants to kill you!";
        public string sloganEnd { get; set; } = "Select \"yes\" to make a contract with an assassin. " +
                                             "Or \"no\" to skip.";
    }
}