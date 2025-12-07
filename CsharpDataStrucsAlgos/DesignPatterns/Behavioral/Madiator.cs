namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Define an object that encapsulates how a set of objects interact, promoting loose coupling by keeping objects from referring to each other explicitly.
/// Usage in .NET: To coordinate communication between components(e.g., using an event aggregator).
/// </summary>
public interface IMediator {
    void SendMessage(string message, Colleague colleague);
}

public abstract class Colleague {
    protected readonly IMediator _mediator;

    protected Colleague(IMediator mediator) {
        _mediator = mediator;
    }
    public abstract void Receive(string message);
}

public class ConcreteColleague1 : Colleague {
    public ConcreteColleague1(IMediator mediator) : base(mediator) { }

    public void Send(string message) {
        _mediator.SendMessage(message, this);
    }

    public override void Receive(string message) {
        Console.WriteLine("Colleague1 received: " + message);
    }
}

public class ConcreteColleague2 : Colleague {
    public ConcreteColleague2(IMediator mediator) : base(mediator) { }

    public void Send(string message) {
        _mediator.SendMessage(message, this);
    }

    public override void Receive(string message) {
        Console.WriteLine("Colleague2 received: " + message);
    }
}

public class ConcreteMediator : IMediator {
    private readonly List<Colleague> _colleagues = new List<Colleague>();

    public void RegisterColleague(Colleague colleague) {
        _colleagues.Add(colleague);
    }

    public void SendMessage(string message, Colleague sender) {
        foreach (var colleague in _colleagues) {
            if (colleague != sender) {
                colleague.Receive(message);
            }
        }
    }
}


