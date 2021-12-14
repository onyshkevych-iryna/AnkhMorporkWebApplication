namespace AnkhMorporkWebApp.Models
{
    public class PlayerThiefViewModel
    {
        public Player Player { get; set; }
        public Thief Thief { get; set; }
        public string SloganStart { get; set; } = "You met a thieve!";
        public string SloganToPay { get; set; } = "To pay him";
        public string SloganEnd { get; set; } = "- select \"yes\". To skip - select \"no\".";
    }
}