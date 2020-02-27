namespace AnimalShelter.Models
{
  public class Cat
  {
    private string _name;
    private int _age;
    private string _health;
    private string _maintenance;

    public Cat(string name, int age, string health, string maintenance)
    {
      _name = name;
      _age = age;
      _health = health;
      _maintenance = maintenance;
    }
    
    // new Cat + newCat

    public void SetName(string name)
    {
      _name = name;
    }
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

    public string GetName()
    {
      return _name;
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