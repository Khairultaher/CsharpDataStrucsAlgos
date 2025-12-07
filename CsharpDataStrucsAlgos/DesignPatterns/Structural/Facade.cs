using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Structural;


/// <summary>
/// Intent: Provide a unified interface to a set of interfaces in a subsystem, simplifying usage.
/// Usage in .NET: To wrap complex libraries or subsystems(e.g., simplifying calls to multiple microservices).
/// </summary>
public class SubsystemA {
    public void OperationA() => Console.WriteLine("SubsystemA: Operation A");
}

public class SubsystemB {
    public void OperationB() => Console.WriteLine("SubsystemB: Operation B");
}

public class SystemFacade {
    private readonly SubsystemA _a = new SubsystemA();
    private readonly SubsystemB _b = new SubsystemB();
    public void Execute() {
        _a.OperationA();
        _b.OperationB();
    }
}

