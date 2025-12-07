using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Avoid coupling the sender of a request to its receiver by giving multiple objects a chance to handle the request.
/// Usage in .NET: To implement middleware pipelines(like ASP.NET Core middleware) where requests pass through a chain of handlers.
/// </summary>
public abstract class Handler {
    protected Handler _next;
    public void SetNext(Handler next) => _next = next;
    public abstract void Handle(string request);
}

public class AuthHandler : Handler {
    public override void Handle(string request) {
        if (request == "Auth")
            Console.WriteLine("Handling authentication.");
        else
            _next?.Handle(request);
    }
}

public class LoggingHandler : Handler {
    public override void Handle(string request) {
        if (request == "Log")
            Console.WriteLine("Handling logging.");
        else
            _next?.Handle(request);
    }
}
