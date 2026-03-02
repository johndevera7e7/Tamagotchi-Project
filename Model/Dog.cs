using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    
    public class Dog: AOrganic
    {

        public Dog(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            type = State.Happy;
        }

        public Dog(int age, string breed)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = breed;
            type = State.Happy;
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = breed;
            type = State.Happy;
        }

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
        }

        public Dog(int age)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = BREED;
            type = State.Happy;
        }

        public Dog(string name)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = BREED;
            type = State.Happy;
        }

        public Dog()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Breed = BREED;
            type = State.Happy;
        }

    }
}
