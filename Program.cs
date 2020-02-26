using System;
using System.Collections.Generic;
using AnimalShelter.Models;

namespace AnimalShelter
{
  public class Program
  {
    public static void Main()
    {
      Cattery myCattery = new Cattery(5);
      int NumberOfCats = myCattery.GetPopulation();
      Console.WriteLine("Welcome to Owens Cattery!");
      Console.WriteLine($"We have {NumberOfCats} cats available for adoption!");
      Console.Write($"Would you like to adopt, donate a cat, or leave? ");
      string AdoptOrDonate = Console.ReadLine();

      if (AdoptOrDonate == "adopt") 
      {
        myCattery.RemoveCat();
      } 
      else if (AdoptOrDonate == "donate") 
      {
        myCattery.AddCat();
      }
      else if (AdoptOrDonate == "leave")
      {
        Console.WriteLine("Okay, see you around!");
      }
      Console.WriteLine($"Cattery population is now {myCattery.GetPopulation()}");
    }
  }
}
