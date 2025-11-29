namespace OOP_LAB3.Entities;

public class Dish
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public double Calories { get; set; }

    public Dish(string name, decimal price, string description, double calories)
    {
        Name = name;
        Price = price;
        Description = description;
        Calories = calories;
    }
}