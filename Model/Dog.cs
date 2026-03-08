using System;
using System.Collections.Generic;
using System.Text;
using Tamagotchi.Interfaces;

namespace Tamagotchi.Model
{
    
    public class Dog: AOrganic
    {
        const string petAnimal = "Dog";

        public Dog(string name, int age, string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            this.Animal = petAnimal;
            type = State.Happy;
            newStats = new Stats();
            
            
        }

        public Dog(int age, string breed)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = breed;
            this.Animal = petAnimal;
            type = State.Happy;
            newStats = new Stats();
            
            
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = breed;
            this.Animal = petAnimal;
            type = State.Happy;
            newStats = new Stats();
            
            
        }

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
            newStats = new Stats();
            
            
        }

        public Dog(int age)
        {
            this.Name = NAME;
            this.Age = age;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
            newStats = new Stats();
            
            
        }

        public Dog(string name)
        {
            this.Name = name;
            this.Age = AGE;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
            newStats = new Stats();
            
            
        }

        public Dog()
        {
            this.Name = NAME;
            this.Age = AGE;
            this.Breed = BREED;
            this.Animal = petAnimal;
            type = State.Happy;
            newStats = new Stats();
            
            
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} goes for a walk!");
        }

        
    }
}
