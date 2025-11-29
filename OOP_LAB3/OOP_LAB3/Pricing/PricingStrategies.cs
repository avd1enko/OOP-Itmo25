namespace OOP_LAB3.Pricing;
using OOP_LAB3.Entities;

// pricing strategis for different orders
public interface IPricingStrategy
{
    decimal CalculateTotal(Order order);
}

public class StandardPricingStrategy : IPricingStrategy
{
    public decimal CalculateTotal(Order order)
    {
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }
}

public class ExpressPricingStrategy : IPricingStrategy
{
    private const decimal ExpressFee = 5.00m;

    public decimal CalculateTotal(Order order)
    {
        decimal total = 0;
        foreach (var item in order.Items)
        {
            total += item.GetTotalPrice();
        }
        return total + ExpressFee;
    }
    
}

public class DiscountPricingStrategy : IPricingStrategy
{
    private readonly IPricingStrategy _baseStrategy;
    private readonly decimal _discount; // десятичные дроби от 0 до 1
    public DiscountPricingStrategy(IPricingStrategy baseStartegy, decimal discount)
    {
        _baseStrategy = baseStartegy;
        _discount = discount;
    }

    public decimal CalculateTotal(Order order)
    {
        decimal baseTotal = _baseStrategy.CalculateTotal(order);
        return baseTotal *(1 - _discount);
    }
}