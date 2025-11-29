namespace OOP_LAB3.Tests;
using OOP_LAB3.Entities;
using OOP_LAB3.Pricing;


public class PricingStrategyTests
{
    [Fact]
    public void PricingStrategySTests()
    {
        // arrange 
        var order = new StandardOrder(1, "123 Main St");
        var dish1 = new Dish("Pizza", 10.00m, "", 1000);
        var dish2 = new Dish("Pasta", 8.00m, "", 800);
        order.AddItem(dish1, 2); // 20.00
        order.AddItem(dish2, 1); // 8.00
        // act
        var total = order.GetOrderPrice();

        Assert.Equal(28.00m, total);
    }

    [Fact]
    public void ExpressPricing_Adds_Express_Fee()
    {
        // arrange 
        var order = new ExpressOrder(2, "123 Main St");
        var dish1 = new Dish("Burger", 12.00m, "", 900);

        order.AddItem(dish1, 2);
        // act
        var total = order.GetOrderPrice();

        // assert
        // 5 is a express fee
        Assert.Equal(29.00m, total);
    }

    [Fact]
    public void DiscountPricing_Applies_Discount_On_Base_Strategy()
    {
        // arrange
        var order = new StandardOrder(3, "Discount address");
        var dish = new Dish("Dish", 20.00m, "test", 500);

        order.AddItem(dish, 1); // 20
        order.PricingStrategy = new DiscountPricingStrategy(
            new StandardPricingStrategy(),
            0.5m
        );
        // act
        var total = order.GetOrderPrice();
        // assert
        Assert.Equal(10.00m, total);

    }
}
