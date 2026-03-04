using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Model
{
    public abstract class APet: Play
    {
        protected const string NAME = "Unknown";
        protected const int AGE = 0;

        protected string Name { get; set; }
        protected int Age { get; set; }

        public APet(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Stats Energy = new Stats();
        }

        public APet (int age) 
        {
            this.Age = age;
            this.Name = NAME;
            Stats Energy = new Stats();
        }

        public APet(string name)
        {
            this.Age = AGE;
            this.Name = name;
            Stats Energy = new Stats();
        }

        public APet()
        {
            this.Age = AGE;
            this.Name = NAME;
            Stats Energy = new Stats();
        }

        public virtual void Play(Stats energy)
        {
            energy.Quantity = energy.Quantity - 20;
        }
    }
}
