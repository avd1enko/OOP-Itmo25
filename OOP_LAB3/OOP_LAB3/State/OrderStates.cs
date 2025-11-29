namespace OOP_LAB3.State;
using OOP_LAB3.Entities;

// using state pattern for order states
// паттерн использован для управления состоянием заказа. В абстрактом order есть ссылка на текущее состояние, а конкретные классы, реализованные
// здесь определяют переход между разными этапами заказа. Это позволяет не писать if-else/swtich-case в order,а вынести в отдеьлные классы
public interface IOrderState
{
    string Name { get; }
    void Step(Order order);
}

public class PreparingState : IOrderState
{
    public string Name { get; } = "Preparing";

    public void Step(Order order)
    {
        order.State = new DeliveringState();
    }
}

public class DeliveringState : IOrderState
{
    public string Name { get; } = "Delivering";

    public void Step(Order order)
    {
        order.State = new CompletedState();
    }
}

public class CompletedState : IOrderState
{
    public string Name { get; } = "Completed";

    public void Step(Order order)
    {
        // final
    }
}