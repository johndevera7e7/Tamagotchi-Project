using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Model
{
    public abstract class APet: Play, Sleep
    {
        protected const string NAME = "Unknown";
        protected const int AGE = 0, ENERGY = 100;

        protected virtual string Animal { get; set; }
        protected string Name { get; set; }
        protected int Age { get; set; }

        protected Stats newStats;
        public APet(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            newStats = new Stats();
        }

        public APet (int age) 
        {
            this.Age = age;
            this.Name = NAME;
            newStats = new Stats();
        }

        public APet(string name)
        {
            this.Age = AGE;
            this.Name = name;
            newStats = new Stats();
        }

        public APet()
        {
            this.Age = AGE;
            this.Name = NAME;
            newStats = new Stats();
        }

        public abstract void Play();

        public abstract void Sleep();

        public abstract void Fix();
        public abstract void Grease();

        public virtual string getAnimal()
        {
            return this.Animal;
        }

        public virtual void getStats()
        {
            Console.WriteLine($"Energy: {this.newStats.Energy}");
        }
    }
}
