﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonTemps.Areas.Systeem.Models
{
    public class Tafels
    {
        public int Id { get; set; }
        public string TafelNaam { get; set; }
        public int Zitplaatsen { get; set; }
        public bool Bezet { get; set; }
    //    public double y { get; set; }
    //    public double x { get; set; }
    }
}
