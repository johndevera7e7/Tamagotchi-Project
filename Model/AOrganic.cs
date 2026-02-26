using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    abstract class AOrganic: APet
    {
        const string BREED = "Unknown";
        protected string Breed { get; set; }

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
        }

        public AOrganic(int age, string breed)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = breed;
            type = State.Happy;
        }

        public AOrganic(string name, string breed)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = breed;
            type = State.Happy;
        }

        public AOrganic(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
        }

        public AOrganic(int age)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
        }

        public AOrganic(string name)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = BREED;
            type = State.Happy;
        }
    }
}
