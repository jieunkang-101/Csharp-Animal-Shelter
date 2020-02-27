using System;
using System.Collections.Generic;
using AnimalShelter.Models;

namespace AnimalShelter
{
  public class Program
  {

    //establish specific cattery
    public static Cat cat1 = new Cat("Charlie", 2, "healthy", "difficult");
    public static Cat cat2 = new Cat("Momo", 5, "healthy", "nice");
    public static Cat cat3 = new Cat("Brooke", 9, "spunky", "awesome");
    public static Cattery myCattery = new Cattery();
    public static void Main()
    {
        
      myCattery.AddCat(cat1);
      myCattery.AddCat(cat2);
      myCattery.AddCat(cat3);
      int NumberOfCats = myCattery.GetPopulation();
      Console.WriteLine("Welcome to Owens Cattery!");
      Console.WriteLine($"We have {myCattery.GetPopulation()} cats available for adoption!");
      Console.Write($"Would you like to adopt, donate a cat, or leave? ");
      string AdoptOrDonate = Console.ReadLine();

      if (AdoptOrDonate == "adopt") 
      {
        myCattery.RemoveCat();
        AdoptCat();
      } 
      else if (AdoptOrDonate == "donate") 
      {
        Cat newCat = CatInfo();
        myCattery.AddCat(newCat);
      }
      else if (AdoptOrDonate == "leave")
      {
        Console.WriteLine("Okay, see you around!");
      }
      Console.WriteLine($"Cattery population is now {myCattery.GetPopulation()}");
      Main();
    }

    public static Cat CatInfo()
    {
      Console.WriteLine("Enter an name of cat. ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter an age of cat. ");
      int age = int.Parse(Console.ReadLine());

      Console.WriteLine("Tell us about your cat's health level. ");
      string health = Console.ReadLine();

      Console.WriteLine("What specific maintenance trait to your cat? ");
      string maintenane = Console.ReadLine();


      Cat newCat = new Cat(name ,age, health, maintenane);
      newCat.SetName(name);
      newCat.SetAge(age);
      newCat.SetHealth(health);
      newCat.SetMaintenance(maintenane);

      string newName = newCat.GetName();
      int newAge = newCat.GetAge();
      string newHealth = newCat.GetHealth();
      string newMaintenance = newCat.GetMaintenance();
      
      Console.WriteLine("Donated cat's information");
      Console.WriteLine($"This is {newName}! Meow");
      Console.WriteLine($"This cat is {newAge} years old.");
      Console.WriteLine($"This cat's healthe level is {newHealth}");
      Console.WriteLine($"This cat need to {newMaintenance}");
      Console.WriteLine($"WE NOW HAVE: {myCattery.GetAvailableCats()}");
      return newCat;
    }
    public static void AdoptCat()
    {
      Console.WriteLine("Thank you dor adopting a cat!");
    }
  }
}
