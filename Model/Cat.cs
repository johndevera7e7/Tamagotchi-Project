using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Tamagotchi.Model
{
    public class Cat: AOrganic
    {
        public Cat(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            type = State.Happy;
        }

        public Cat(int age, string breed)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = breed;
            type = State.Happy;
        }

        public Cat(string name, string breed)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = breed;
            type = State.Happy;
        }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
        }

        public Cat(int age)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
        }

        public Cat(string name)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = BREED;
            type = State.Happy;
        }

        public Cat()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Breed = BREED;
            type = State.Happy;
        }

        public void Meow()
        {
            Console.WriteLine($"{this.Name} says: MEOW!");
        }
    }
}
