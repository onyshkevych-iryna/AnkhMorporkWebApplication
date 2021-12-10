﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnkhMorporkWebApp.Models
{
    public class PlayerAssassinViewModel
    {
        public Player player { get; set; }
        public Assassin Assassin { get; set; }
        [Required(ErrorMessage = "Amount is required!")]
         public decimal amount { get; set; }
        public string slogan { get; set; } = "Someone wants to kill you! Input sum of money to make a contract with an assassin. " +
                                             "Or push \"no\" to skip.";
    }
}