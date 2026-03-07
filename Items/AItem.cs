using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Items
{
    public abstract class AItem
    {
        protected const int USES = 3;
        protected const string NAME = "";
        protected int Uses { get; set; }
        protected string Name { get; set; }


        public AItem(int uses, string name)
        {
            this.Uses = uses;
            this.Name = name;
        }

        public AItem(string name)
        {
            this.Uses = USES;
            this.Name = name;
        }

        public AItem()
        {
            this.Uses = USES;
            this.Name = NAME;
        }
    }
}
