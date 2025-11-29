namespace OOP_LAB3.Observers;
using OOP_LAB3.Entities;

// observer pattern for order updates
// добавили соответсвтвующие методы в order для регистрации, в том числе список обсерверов,
// удаления и уведомления наблюдателей

// любой класс, реализующий этот интерфейс - наблюдатель
public interface IOrderObserver
{
    void Update(Order order);
}

public class OrderObserver : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"Order {order.Id} is noe {order.State.Name}");
    }
}