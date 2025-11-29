using OOP_LAB3.Pricing;

namespace OOP_LAB3.Entities;

// order types 
public class StandardOrder : Order
{
    public StandardOrder(int id, string address) : base(id, address)
    {
        PricingStrategy = new StandardPricingStrategy();
    }
}
public class ExpressOrder : Order
{
    public ExpressOrder(int id, string address) : base(id, address)
    {
        PricingStrategy = new ExpressPricingStrategy();
    }
}