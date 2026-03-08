using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public abstract class AOrganic : APet
    {
        protected const int HEALTH = 100, HUNGER = 100;
        protected const string BREED = "Unknown";
        protected string Breed { get; set; }
        protected int Hunger { get; set; }
        protected int Health { get; set; }
        protected State type { get; set; }

        protected enum State
        {
            Happy,
            Sad,
            Angry,
            Tired,
            Sick
        }

        public AOrganic (string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            type = State.Happy;
            newStats = new Stats();
        }

        public AOrganic(int age, string breed)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = breed;
            type = State.Happy;
            newStats = new Stats();
        }

        public AOrganic(string name, string breed)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = breed;
            type = State.Happy;
            newStats = new Stats();
        }

        public AOrganic(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
            newStats = new Stats();
        }

        public AOrganic(int age)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
            newStats = new Stats();
        }

        public AOrganic(string name)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = BREED;
            type = State.Happy;
            newStats = new Stats();
        }

        public AOrganic()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Breed = BREED;
            type = State.Happy;
            newStats = new Stats();
        }

        public virtual void getStats()
        {
            Console.WriteLine($"Energy: {this.newStats.Energy} / Hunger: {this.newStats.Hunger} / Health: {this.newStats.Health}");
        }

        public override void Play()
        {
            if (type == State.Angry)
            {
                Console.WriteLine("{0} is too angry to play!", this.Name);
            }
            else if (type == State.Tired)
            {
                Console.WriteLine("{0} is too tired to play!", this.Name);
            }
            else {
                type = State.Happy;
                Console.WriteLine("You played with {0}!", this.Name);
                this.newStats.Energy = newStats.Energy - 20;
                this.newStats.Hunger = newStats.Hunger - 20;
                if (newStats.Hunger <= 50)
                {
                    type = State.Angry;
                }
            }
        }

        public override void Sleep()
        {
            if (type == State.Angry)
            {
                Console.WriteLine("{0} is too angry to play!", this.Name);
            }
            else
            {
                type = State.Happy;
                this.newStats.Energy = newStats.Energy = 100;
                this.newStats.Hunger = newStats.Hunger - 20;
                if (newStats.Hunger <= 50)
                {
                    type = State.Angry;
                }
            }
        }
    }
}
