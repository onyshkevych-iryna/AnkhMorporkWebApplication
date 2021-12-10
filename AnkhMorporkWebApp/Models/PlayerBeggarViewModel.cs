namespace AnkhMorporkWebApp.Models
{
    public class PlayerBeggarViewModel
    {
        public Player player { get; set; }
        public Beggar begar { get; set; }
        public string slogan { get; set; } = "You met a beggar!";
        public string slogans { get; set; } = "- enter \"yes\". To skip - enter \"no\".";
        public string sloganpay { get; set; } = "To pay them ";
        public string sloganBeer { get; set; } = "To share a beer with them";
    }
}