using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Tamagotchi.Model
{
    public class Chicken: AOrganic
    {
        const string petAnimal = "Chicken";

        public Chicken(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            this.Animal = petAnimal;
            type = State.Happy;
        }

        public Chicken(int age, string breed)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = breed;
            this.Animal = petAnimal;
            type = State.Happy;
        }

        public Chicken(string name, string breed)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = breed;
            this.Animal = petAnimal;
            type = State.Happy;
        }

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
        }

        public Chicken(int age)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
        }

        public Chicken(string name)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
        }

        public Chicken() 
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
        }

        public void Egg()
        {
            Console.WriteLine($"{this.Name} laid an egg!");
        }
    }
}
