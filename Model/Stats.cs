using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public abstract class Stats
    {
        protected const int ENERGY = 100;
        protected int Energy { get; set; }

        Stats(int energy)
        {
            this.Energy = energy;
        }

        Stats()
        {
            this.Energy = ENERGY;
        }
    }
}
