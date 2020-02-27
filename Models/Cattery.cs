using System;
using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Cattery
  {
    List<Cat> Cats = new List<Cat>() {}; 

    private int _population;
    private List<Cat> _availableCats;


    public Cattery()
    {
      _population = 0;
      _availableCats = Cats;
    }

    public int GetPopulation()
    {
      return _population;
    }

    public List<Cat> GetAvailableCats()
    {
      return _availableCats;
    }

    // public void AddCat()
    public void AddCat(Cat newCat)
    {
      _population ++;
      Cats.Add(newCat);
    }
    //in main, specify index of chosen cat , asame index in variable with int datatype
    // public void RemoveCat(int chosenCatIndex)
    public void RemoveCat()
    {
      _population --;
      // Cats.RemoveAt(chosenCatIndex);
    }
  }
}