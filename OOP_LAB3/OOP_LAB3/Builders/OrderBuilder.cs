namespace OOP_LAB3.Builders;
using OOP_LAB3.Entities;

// builder pattern for creating orders

// используется паттерн builder для пошагового создания заказа

public class OrderBuilder
{
    private Order _order;
    
    public void CreateStandartOrder(int id, string address)
    {
        _order = new StandardOrder(id, address);
    }
    public void CreateExpressOrder(int id, string address)
    {
        _order = new ExpressOrder(id, address);
    }
    public void AddItem(Dish dish, int quantity)
    {
        _order.AddItem(dish, quantity);
    }
    public Order GetOrder()
    {
        return _order;
    }
}