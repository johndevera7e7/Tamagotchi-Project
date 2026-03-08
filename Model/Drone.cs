using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Tamagotchi.Model
{
    public class Drone: AMetal
    {
        const string petAnimal = "Drone";

        public Drone(string name, int age, int generation)
        {
            this.Name = name;
            this.Age = age;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Drone(int age, int generation)
        {
            this.Name = NAME;
            this.Age = age;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Drone(string name, int generation)
        {
            this.Name = name;
            this.Age = AGE;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Drone(int generation)
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = generation;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public Drone()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Generation = GENERATION;
            this.Animal = petAnimal;
            type = Condition.Perfect;
            newStats = new Stats();
        }

        public override void Eat()
        {
            
        }
    }
}
