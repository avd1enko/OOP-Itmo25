namespace OOP_LAB3.Factory;
using OOP_LAB3.Entities;

// abstract factory for creating different types of menu items
// фабрики создают семейства связанных объектов для разных меню, код работает только с интерфейсом и не зависиот от классов блюд
public interface IMenuFactory
{
    Dish CreateDish();
    Dish CreateDrink();
    Dish CreateDessert();
}

public class StandardMenuFactory : IMenuFactory
{
    public Dish CreateDish()
    {
        return new Dish("Dish", 10.00m, description:"", calories: 500);
    }

    public Dish CreateDrink()
    {
        return new Dish("Drink", 3.00m, description:"", calories: 300);
    }

    public Dish CreateDessert()
    {
        return new Dish("Dessert", 5.00m, description:"", calories: 1000);
    }
}

public class KidsMenuFactory : IMenuFactory
{
    public Dish CreateDish()
    {
        return new Dish("Kid's Dish", 6.00m, description:"", calories: 400);
    }

    public Dish CreateDrink()
    {
        return new Dish("Kid's Drink", 2.00m, description:"", calories: 200);
    }

    public Dish CreateDessert()
    {
        return new Dish("Kid's Dessert", 4.00m, description:"", calories: 800);
    }
}