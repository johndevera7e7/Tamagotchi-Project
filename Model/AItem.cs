using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public abstract class AItem
    {
        protected const int USES = 3;
        protected int Uses { get; set; }

        public AItem (int uses)
        {
            this.Uses = uses;
        }

        public AItem()
        {
            this.Uses = USES;
        }
    }
}
