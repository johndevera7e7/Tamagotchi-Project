using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Tamagotchi.Model
{
    abstract class AMetal: APet
    {
        const int GENERATION = 1;
        protected int Generation { get; set; }
        protected Condition type { get; set; }

        protected enum Condition
        {
            Perfect,
            Broken,
            Recharging,
            No_energy
        }

        public AMetal(string name, int age, int generation)
        {
            this.Name = name;
            this.Age = age;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public AMetal(int age, int generation)
        {
            this.Name = NAME;
            this.Age = age;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public AMetal(string name, int generation)
        {
            this.Name = name;
            this.Age = AGE;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public AMetal(int generation)
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = generation;
            type = Condition.Perfect;
        }

        public AMetal()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = GENERATION;
            type = Condition.Perfect;
        }
    }
}
