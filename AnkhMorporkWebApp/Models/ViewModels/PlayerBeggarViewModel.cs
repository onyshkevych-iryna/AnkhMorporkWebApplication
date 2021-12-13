namespace AnkhMorporkWebApp.Models
{
    public class PlayerBeggarViewModel
    {
        public Player Player { get; set; }
        public Beggar Beggar { get; set; }
        public string SloganStart { get; set; } = "You met a beggar!";
        public string SloganEnd { get; set; } = "- select \"yes\". To skip - select \"no\".";
        public string SloganToPay { get; set; } = "To pay them ";
        public string SloganToShareBeer { get; set; } = "To share a beer with them";
    }
}