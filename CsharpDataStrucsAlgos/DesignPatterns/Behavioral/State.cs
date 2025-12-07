using CsharpDataStrucsAlgos.DesignPatterns.Structural;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Allow an object to alter its behavior when its internal state changes, appearing to change its class.
/// Usage in .NET: Modeling state machines(e.g., order processing in e-commerce systems).
/// </summary>
public interface IOrderState {
    void ProcessOrder(Order order);
}

public class NewOrderState : IOrderState {
    public void ProcessOrder(Order order) {
        Console.WriteLine("Processing new order.");
        order.State = new ProcessedOrderState();
    }
}

public class ProcessedOrderState : IOrderState {
    public void ProcessOrder(Order order) => Console.WriteLine("Order already processed.");
}

public class Order {
    public IOrderState State { get; set; }
    public Order() { State = new NewOrderState(); }
    public void Process() => State.ProcessOrder(this);
}

