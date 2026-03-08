using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public abstract class AOrganic : APet
    {
        protected const int HEALTH = 100, HUNGER = 100;
        protected const string BREED = "Unknown";
        protected const string NotAvailable = "That is not an available option for this pet!";
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
            if(type == State.Sick)
            {
                Console.WriteLine("{0} is sick! Give it some medicine!");
            }
            else if (type == State.Angry)
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
                this.newStats.Health = (newStats.Energy + newStats.Hunger) / 2;
                if (newStats.Health <= 20)
                {
                    type = State.Sick;
                    Console.WriteLine("{0} is now sick, heal it!", Name);
                }
                else if (newStats.Hunger <= 50)
                {
                    type = State.Angry;
                    Console.WriteLine("{0} is now angry, feed it!", Name);
                }
            }
        }

        public override void Sleep()
        {
            if (type == State.Sick)
            {
                Console.WriteLine("{0} is sick! Give it some medicine!");
            }
            else
            {
                type = State.Happy;
                newStats.Energy = newStats.Energy = 100;
                newStats.Hunger = newStats.Hunger - 20;
                newStats.Health = (newStats.Energy + newStats.Hunger) / 2;
                if (newStats.Health < 20) {
                    type = State.Sick;
                }
                else if (newStats.Hunger <= 50)
                {
                    type = State.Angry;
                    Console.WriteLine("{0} is now angry, feed it!", Name);
                }
            }
        }

        public void Heal()
        {
            this.newStats.Energy = 100;
            this.newStats.Hunger = 100;
            this.newStats.Health = (newStats.Energy + newStats.Hunger) / 2;
            type = State.Happy;
            Console.WriteLine("{0} is now healed!");
        }

            public override void Eat()
        {
            this.newStats.Hunger = 100;
            this.type = State.Happy;
            newStats.Health = (newStats.Energy + newStats.Hunger) / 2;
            if (newStats.Health <= 20)
            {
                type = State.Sick;
                Console.WriteLine("{0} is now sick, heal it!", Name);
            }
            else if (newStats.Energy <= 30)
            {
                type = State.Tired;
                Console.WriteLine("{0} is now tired, let it sleep!", Name);
            }
        }

        public override void Fix()
        {
            Console.WriteLine(NotAvailable);
        }

        public override void Grease()
        {
            Console.WriteLine(NotAvailable);
        }
    }
}
