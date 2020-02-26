namespace AnimalShelter.Models
{
  public class Cat
  {
    private int _age;
    private string _health;
    private string _maintenance;

    public Cat(int age, string health, string maintenance)
    {
      _age = age;
      _health = health;
      _maintenance = maintenance;
    }
    
    // new Cat + newCat

    public void SetAge(int age)
    {
      _age = age;
    }
    public void SetHealth(string health)
    {
      _health = health;
    }
    public void SetMaintenance(string maintenance)
    {
      _maintenance = maintenance;
    }
    public int GetAge()
    {
      return _age;
    }
    public string GetHealth()
    {
      return _health;
    }
    public string GetMaintenance()
    {
       return _maintenance;
    }
  }
}