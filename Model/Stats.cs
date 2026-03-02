using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public class Stats
    {
        protected const int QUANTITY = 100;
        protected string Name { get; set; }
        protected int Quantity { get; set; }
        
        public Stats(string name)
        {
            this.Name = name;
            this.Quantity = QUANTITY;
        }

        
    }
}
