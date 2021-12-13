namespace AnkhMorporkWebApp.Models
{
    public class PlayerFoolViewModel
    {
        public Player player { get; set; }
        public Fool fool { get; set; }
        public string sloganStart { get; set; } = "You met a fool!";
        public string sloganFirstPart { get; set; } = "To join their offer to work as";
        public string sloganSecondPart { get; set; } = "and earn";
        public string sloganEnd { get; set; } = "- select \"yes\". To skip - select \"no\".";
    }
}