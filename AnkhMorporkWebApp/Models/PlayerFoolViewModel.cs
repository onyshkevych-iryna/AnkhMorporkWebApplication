namespace AnkhMorporkWebApp.Models
{
    public class PlayerFoolViewModel
    {
        public Player player { get; set; }
        public Fool fool { get; set; }
        public string slogan { get; set; } = "You met a fool! To join their offer to work as";
        public string slogans { get; set; } = "and earn";
        public string slogant { get; set; } = "- enter \"yes\". To skip - enter \"no\".";
    }
}