namespace AnkhMorporkWebApp.Models
{
    public class PlayerThiefModel
    {
        public Player player { get; set; }
        public Thief thief { get; set; }
        public string slogan { get; set; } = "You met a thieve! To pay him";
        public string slogans { get; set; } = "- enter \"yes\". To skip - enter \"no\".";
    }
}