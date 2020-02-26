namespace AnimalShelter.Models
{
  public class Cattery
  {
    private int _population;

    public Cattery(int population)
    {
      _population = population;
    }

    public int GetPopulation()
    {
      return _population;
    }

    public void AddCat()
    {
      _population ++;
      // Cat.Creat()
    }
    public void RemoveCat()
    {
      _population --;
      // Cat.Creat()
    }
  }
}