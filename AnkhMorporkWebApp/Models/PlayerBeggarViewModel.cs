namespace AnkhMorporkWebApp.Models
{
    public class PlayerBeggarViewModel
    {
        public Player player { get; set; }
        public Beggar begar { get; set; }
        public string sloganStart { get; set; } = "You met a beggar!";
        public string sloganEnd { get; set; } = "- select \"yes\". To skip - select \"no\".";
        public string sloganToPay { get; set; } = "To pay them ";
        public string sloganToShareBeer { get; set; } = "To share a beer with them";
    }
}