namespace AnkhMorporkWebApp.Models
{
    public class PlayerBeggarViewModel
    {
        public Player player { get; set; }
        public Beggar begar { get; set; }
        public string slogan { get; set; } = "You met a beggar! To pay them";
        public string slogans { get; set; } = "- enter \"yes\". To skip - enter \"no\".";
    }
}