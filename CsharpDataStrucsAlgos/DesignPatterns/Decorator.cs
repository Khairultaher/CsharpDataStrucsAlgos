using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns;

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

