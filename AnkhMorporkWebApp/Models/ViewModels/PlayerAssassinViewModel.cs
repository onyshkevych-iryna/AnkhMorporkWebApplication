using System.ComponentModel.DataAnnotations;
using Foolproof;

namespace AnkhMorporkWebApp.Models
{
    public class PlayerAssassinViewModel
    {
        public Player Player { get; set; }
        public Assassin Assassin { get; set; }
        public decimal BalanceOfPlayer { get; set; }
        //[Required(ErrorMessage = "Amount is required!")]
        [Required]
        public decimal Amount { get; set; }
        public string SloganStart { get; set; } = "Someone wants to kill you!";
        public string SloganEnd { get; set; } = "Select \"yes\" to make a contract with an assassin. " +
                                             "Or \"no\" to skip.";
    }
}