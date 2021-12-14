namespace AnkhMorporkWebApp.Models
{
    public class Assassin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MinReward { get; set; }
        public decimal MaxReward { get; set; }
        public bool IsOccupied { get; set; }
    }
}