using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Structural;

/// <summary>
/// Intent: Decouple an abstraction from its implementation so the two can vary independently.
/// Usage in .NET: To separate UI logic from platform-specific implementations.
/// </summary>

// Implementor
public interface IDevice {
    void Enable();
    void Disable();
}

// Concrete Implementor
public class TV : IDevice {
    public void Enable() => Console.WriteLine("TV On");
    public void Disable() => Console.WriteLine("TV Off");
}

// Abstraction
public abstract class RemoteControl {
    protected IDevice _device;
    public RemoteControl(IDevice device) { _device = device; }
    public abstract void TurnOn();
}

// Refined Abstraction
public class ConcreteRemoteControl : RemoteControl {
    public ConcreteRemoteControl(IDevice device) : base(device) { }
    public override void TurnOn() => _device.Enable();
}

