using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Tamagotchi.Model
{
    public class Walker: AMetal
    {
        const string petAnimal = "Walker";
        public Walker(string name, int age, int generation)
        {
            this.Name = name;
            this.Age = age;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Walker(int age, int generation)
        {
            this.Name = NAME;
            this.Age = age;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Walker(string name, int generation)
        {
            this.Name = name;
            this.Age = AGE;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Walker(int generation)
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Walker()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = GENERATION;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }
    }
}
