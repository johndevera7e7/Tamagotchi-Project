using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public class Stats
    {
        protected const int QUANTITY = 100;
        public int Quantity { get; set; }
        
        public Stats()
        {
            this.Quantity = QUANTITY;
        }

        
    }
}
