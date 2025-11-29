using System.Runtime.CompilerServices;
using OOP_LAB3.Pricing;

namespace OOP_LAB3.Tests;

using OOP_LAB3.Entities;
using OOP_LAB3.Observers;
using OOP_LAB3.State;
using OOP_LAB3.Builders;


// наш налюдатель для тестов
public class TestOrderObserver : IOrderObserver
{
    public int CallsCount;
    public string StateName;

    public void Update(Order order)
    {
        CallsCount++;
        StateName = order.State.Name;
    }
}

public class StateObserverTests
{
    [Fact]
    public void Observer_When_State_Changes()
    {
        // arrange
        var order = new StandardOrder(1, "123 Main St");
        var observer = new TestOrderObserver();
        order.Attach(observer);

        // act
        order.MoveToNextState();

        // assert
        Assert.Equal(1, observer.CallsCount);
        Assert.Equal("Delivering", observer.StateName);
    }

    [Fact]
    public void Observer_Detach_Works_Correctly()
    {
        // arrange
        var order = new ExpressOrder(2, "123 Main St");

        var observer = new TestOrderObserver();
        order.Attach(observer);
        order.Detach(observer);

        // act
        order.MoveToNextState();

        // assert 
        Assert.Equal(0, observer.CallsCount);
        Assert.Null(observer.StateName);
    }
}