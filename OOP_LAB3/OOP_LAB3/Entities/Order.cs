namespace OOP_LAB3.Entities;
using OOP_LAB3.Pricing;
using OOP_LAB3.State;
using OOP_LAB3.Observers;

// abstract order
public abstract class Order
{
    public int Id { get; set; }
    public string Address { get; set; }
    public List<OrderItem> Items { get; set; }
    public IOrderState State { get; set; }
    public IPricingStrategy PricingStrategy { get; set; }

    private readonly List<IOrderObserver> _observers = new();

    protected Order(int id, string address)
    {
        Id = id;
        Address = address;
        Items = new List<OrderItem>();
        State = new PreparingState();
    }

    public void AddItem(Dish dish, int quantity)
    {
        var item = new OrderItem(dish, quantity);
        Items.Add(item);
    }

    public void RemoveItem(OrderItem item)
    {
        Items.Remove(item);
    }

    public decimal GetOrderPrice()
    {
        return PricingStrategy.CalculateTotal(this);
    }

    public void Attach(IOrderObserver observer)
    {
        _observers.Add(observer);
    }
    public void Detach(IOrderObserver observer)
    {
        _observers.Remove(observer);
    }
    private void Notify()
    {
        foreach (var o in _observers)
        {
            o.Update(this);
        }
    }
    public void MoveToNextState()
    {
        State.Step(this);
        Notify();
    }
}