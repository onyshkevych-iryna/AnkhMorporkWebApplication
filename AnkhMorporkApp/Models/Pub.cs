using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkApp.Models
{
    public class Pub
    {
        public string Name { get; set; } = "The Mended Drum";
        public decimal Price { get; set; } = 2;
        public int MaxAmountOfBearForPlayer { get; set; } = 2;
    }
}
