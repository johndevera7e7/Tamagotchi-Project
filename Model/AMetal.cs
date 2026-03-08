using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Tamagotchi.Model
{
    public abstract class AMetal: APet
    {
        protected const int GENERATION = 1;
        protected int Generation { get; set; }
        protected Condition type { get; set; }

        Random rnd = new Random();

        protected enum Condition
        {
            Perfect,
            Broken,
            Recharging,
            No_energy,
            Rusty
        }

        public AMetal(string name, int age, int generation)
        {
            this.Name = name;
            this.Age = age;
            this.Generation = generation;
            type = Condition.Perfect;
            Stats newStats = new Stats();
        }

        public AMetal(int age, int generation)
        {
            this.Name = NAME;
            this.Age = age;
            this.Generation = generation;
            type = Condition.Perfect;
            Stats newStats = new Stats();
        }

        public AMetal(string name, int generation)
        {
            this.Name = name;
            this.Age = AGE;
            this.Generation = generation;
            type = Condition.Perfect;
            Stats newStats = new Stats();
        }

        public AMetal(int generation)
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = generation;
            type = Condition.Perfect;
            Stats newStats = new Stats();
        }

        public AMetal()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = GENERATION;
            type = Condition.Perfect; 
            Stats newStats = new Stats();
        }

        public override void Play()
        {
            if (newStats.Energy == 0) 
            {
                Console.WriteLine("{0} has no energy to play!", this.Name);
            }
            else
            {
                Console.WriteLine("You played with {0}!", this.Name);
                this.newStats.Energy = newStats.Energy - 20;
                if (newStats.Energy == 0)
                {
                    type = Condition.No_energy;
                }
            }
        }

        public override void Sleep()
        {
            if (type == Condition.Broken)
            {
                Console.WriteLine("{0} is broken! Fix it first!", this.Name);
            }
            else { 
                Console.WriteLine("{0} is now recharged!", this.Name);
                this.newStats.Energy = 100;
            }
        }
    }
}
