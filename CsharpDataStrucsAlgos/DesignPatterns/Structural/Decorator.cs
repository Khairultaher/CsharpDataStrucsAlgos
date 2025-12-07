using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Structural;

/// <summary>
/// Intent: Attach additional responsibilities to an object dynamically.
/// Usage in .NET: To add behaviors(like logging, caching, or authorization) to service calls without modifying their code.
/// </summary>
public interface IService {
    string Operation();
}

public class BasicService : IService {
    public string Operation() => "Basic Operation";
}

public abstract class ServiceDecorator : IService {
    protected readonly IService _service;
    public ServiceDecorator(IService service) { 
        _service = service; 
    }
    public virtual string Operation() => _service.Operation();
}

public class LoggingDecorator : ServiceDecorator {
    public LoggingDecorator(IService service) : base(service) { 
    }
    public override string Operation() {
        Console.WriteLine("Logging before operation");
        return base.Operation();
    }
}

