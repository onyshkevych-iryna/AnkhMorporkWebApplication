namespace AnkhMorporkWebApp.Models
{
    public class PlayerFoolViewModel
    {
        public Player Player { get; set; }
        public Fool Fool { get; set; }
        public string SloganStart { get; set; } = "You met a fool!";
        public string SloganFirstPart { get; set; } = "To join their offer to work as";
        public string SloganSecondPart { get; set; } = "and earn";
        public string SloganEnd { get; set; } = "- select \"yes\". To skip - select \"no\".";
    }
}