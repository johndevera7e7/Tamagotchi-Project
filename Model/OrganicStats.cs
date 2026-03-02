using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public class OrganicStats
    {
        protected const int HEALTH = 100;
        protected const int HUNGER = 100;

        protected int Health { get; set; }
        protected int Hunger { get; set; }

        public OrganicStats()
        {
            this.Health = HEALTH;
            this.Hunger = HUNGER;
        }

    }
}
