namespace OOP_LAB3.Tests;
using OOP_LAB3.Entities;
using OOP_LAB3.Observers;
using OOP_LAB3.State;
using OOP_LAB3.Builders;

public class OrderBuilderTests
{
    [Fact]
    public void Buiding_Standart_Order()
    {
        //arrange
        var builder = new OrderBuilder();
        var dish1 = new Dish( "Pizza", 10m, "Dish 1", 100);
        var dish2 = new Dish( "Pasta", 15m, "Dish 2", 150);
        
        // act
        builder.CreateStandartOrder(1, "test adderss");
        builder.AddItem(dish1, 1);
        builder.AddItem(dish2, 2);
        var order = builder.GetOrder();
        
        // assert
        Assert.Equal(2, order.Items.Count);
        Assert.Equal(dish1.Name, order.Items[0].Dish.Name);
    }
    
    [Fact]
    public void Building_Express_Order()
    {
        //arrange
        var builder = new OrderBuilder();
        var dish1 = new Dish( "Burger", 12m, "Dish 1", 120);
        var dish2 = new Dish( "Fries", 5m, "Dish 2", 80);
        
        // act
        builder.CreateExpressOrder(2, "express address");
        builder.AddItem(dish1, 2);
        builder.AddItem(dish2, 3);
        var order = builder.GetOrder();
        
        // assert
        Assert.Equal(2, order.Items.Count);
        Assert.Equal(dish2.Name, order.Items[1].Dish.Name);
        
    }
}







