﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkhMorporkWebApp.Models
{
    public class Pub
    {
        public string Name { get; set; } = "The Mended Drum";
        public decimal Price { get; set; } = 2;
        public int MaxAmountOfBeerForPlayer { get; set; } = 2;
    }
}