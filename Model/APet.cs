using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace Tamagotchi.Model
{
    public abstract class APet
    {
        protected const string NAME = "Unknown";
        protected const int AGE = 0;

        protected string Name { get; set; }
        protected int Age { get; set; }

        public APet (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public APet (int age) 
        {
            this.Age = age;
            this.Name = NAME;
        }

        public APet(string name)
        {
            this.Age = AGE;
            this.Name = name;
        }

        public APet()
        {
            this.Age = AGE;
            this.Name = NAME;
        }
    }
}
