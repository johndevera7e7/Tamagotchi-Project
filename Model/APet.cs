using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Tamagotchi.Model
{
    public class APet
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public virtual string GetName()
        {
            return this.Name;
        }

        public virtual void SetName(string name)
        {
            this.Name = name;
        }
    }
}
