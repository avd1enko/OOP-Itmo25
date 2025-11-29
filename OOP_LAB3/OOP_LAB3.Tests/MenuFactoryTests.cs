using OOP_LAB3.Factory;

namespace OOP_LAB3.Tests;
using OOP_LAB3.Entities;
using OOP_LAB3.Observers;
using OOP_LAB3.State;
using OOP_LAB3.Builders;
public class MenuFactoryTests
{
    [Fact]
    public void CreateStandardDishes()
    {
        // arrange
        IMenuFactory factory = new StandardMenuFactory();
        // act
        Dish main = factory.CreateDish();
        Dish drink = factory.CreateDrink();
        Dish dessert = factory.CreateDessert();
        // assert
        Assert.Equal("Dish", main.Name);
        Assert.Equal(10m, main.Price);
        Assert.Equal("Drink", drink.Name);
        Assert.Equal(3m, drink.Price);
        Assert.Equal("Dessert", dessert.Name);
        Assert.Equal(5m, dessert.Price);
    }

    [Fact]
    public void CreateKidsDishes()
    {
        // arrange
        IMenuFactory factory = new KidsMenuFactory();
        
        // act
        Dish main = factory.CreateDish();
        Dish drink = factory.CreateDrink();
        Dish dessert = factory.CreateDessert();
        
        // assert
        Assert.Equal("Kid's Dish", main.Name);
        Assert.Equal(6m, main.Price);
        Assert.Equal("Kid's Drink", drink.Name);
        Assert.Equal(2m, drink.Price);
        Assert.Equal("Kid's Dessert", dessert.Name);
        Assert.Equal(4m, dessert.Price);
    }

}