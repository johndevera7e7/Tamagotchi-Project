using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using Tamagotchi.Model;

public class Program
{
    public static void Main()
    {
        //Missatges del sistema
        const string petAlreadyAdopted = "You already have a pet adopted!";
        const string goodbyeMSG = "Goodbye!";
        const string newPetAgeInput = "How old is it?";
        const string newPetGenInput = "What's it's generation?";
        const string newPetBreedInput = "What's it's breed?";
        const string newPetNameInput = "What's your new friend's name?";
        const string notAvailable = "That's not an available option!";
        const string menuOptions = "Select an option: Select a pet (1) / Adopt a new pet (2) / Exit the game (0)";
        const string selectPet = "What would you like to adopt?: Dog (1) / Cat (2) / Chicken (3) / Walker (4) / Drone (5)";

        bool petAdopted = false;
        string newPetName, newPetBreed;
        int index, newPetType, newPetAge, newPetGen;


        do 
        {
            index = InputInt(menuOptions);
            switch (index)
            {
                case 1:

                    break;

                case 2:
                    if (!petAdopted)
                    {
                        newPetType = InputInt(selectPet);
                        Console.WriteLine(newPetNameInput);
                        newPetName = Console.ReadLine();
                        switch (newPetType)
                        {
                            case 1:
                                Console.WriteLine(newPetBreedInput);
                                newPetBreed = Console.ReadLine();
                                newPetAge = InputInt(newPetAgeInput);
                                Dog newDog = new Dog(newPetName, newPetAge, newPetBreed);
                                break;
                            case 2:
                                Console.WriteLine(newPetBreedInput);
                                newPetBreed = Console.ReadLine();
                                newPetAge = InputInt(newPetAgeInput);
                                Cat newCat = new Cat(newPetName, newPetAge, newPetBreed);
                                break;
                            case 3:
                                Console.WriteLine(newPetBreedInput);
                                newPetBreed = Console.ReadLine();
                                newPetAge = InputInt(newPetAgeInput);
                                break;
                            case 4:
                                newPetGen = InputInt(newPetGenInput);
                                newPetAge = InputInt(newPetAgeInput);
                                break;
                            case 5:
                                newPetGen = InputInt(newPetGenInput);
                                newPetAge = InputInt(newPetAgeInput);
                                break;
                            default:
                                Console.WriteLine(notAvailable);
                                break;
                        }
                        petAdopted = true;
                    } else
                    {
                        Console.WriteLine(petAlreadyAdopted);
                    }
                    break;
                case 0:
                    Console.WriteLine(goodbyeMSG);
                    break;

                default:
                    Console.WriteLine(notAvailable);
                    break;
            }
        } while (index != 0);
        
        Cat Kiwi = new Cat("Kiwi");
        Kiwi.Meow();
    }

    public static int InputInt(string message)
    {
        const string ErrorMSG = "Error, not an accepted value!";
        int outputInt = 0;
        bool Accepted = false;
        do
        {
            try
            {
                Console.WriteLine(message);
                outputInt = int.Parse(Console.ReadLine());
                Accepted = true;
            }
            catch (FormatException)
            {
                Console.WriteLine(ErrorMSG);
            }
            catch (Exception)
            {
                Console.WriteLine(ErrorMSG);
            }
        } while (!Accepted);
        
        return outputInt;
    }
}