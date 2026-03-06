using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Tamagotchi.Model
{
    public class Stats
    {
        protected const int DEFAULT_STATS = 100;
        public int Energy { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }
        
        public Stats()
        {
            this.Energy = DEFAULT_STATS;
            this.Hunger = DEFAULT_STATS;
            this.Health = DEFAULT_STATS;
        }
    }
}
