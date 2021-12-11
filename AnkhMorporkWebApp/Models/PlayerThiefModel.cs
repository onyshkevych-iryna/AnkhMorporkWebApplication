namespace AnkhMorporkWebApp.Models
{
    public class PlayerThiefModel
    {
        public Player player { get; set; }
        public Thief thief { get; set; }
        public string sloganStart { get; set; } = "You met a thieve!";
        public string sloganToPay { get; set; } = "To pay him";
        public string sloganEnd { get; set; } = "- select \"yes\". To skip - select \"no\".";
    }
}