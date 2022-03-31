using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal 
    {
        public Reptile()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "land";
            Age = 0; 
        }

        public bool IsColdedBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
