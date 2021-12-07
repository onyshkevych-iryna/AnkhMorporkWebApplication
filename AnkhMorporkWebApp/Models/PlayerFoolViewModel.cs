namespace AnkhMorporkWebApp.Models
{
    public class PlayerFoolViewModel
    {
        public Player player { get; set; }
        public Fool fool { get; set; }
        public string slogan { get; set; } = "You met a fool!";
    }
}