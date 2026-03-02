using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Tamagotchi.Model
{
    public class Walker: AMetal
    {
        public Walker(string name, int age, int generation)
        {
            this.Name = name;
            this.Age = age;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public Walker(int age, int generation)
        {
            this.Name = NAME;
            this.Age = age;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public Walker(string name, int generation)
        {
            this.Name = name;
            this.Age = AGE;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public Walker(int generation)
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public Walker()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = GENERATION;
            type = Condition.Perfect;
        }
    }
}
