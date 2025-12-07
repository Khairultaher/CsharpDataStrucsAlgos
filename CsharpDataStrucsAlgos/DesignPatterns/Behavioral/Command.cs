namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Encapsulate a request as an object, thereby letting you parameterize clients with queues, requests, or operations.
/// Usage in .NET: For implementing undo/redo operations or encapsulating UI commands in desktop applications.
/// </summary>
/// <typeparam name="TResult"></typeparam>

// Command Interface
public interface ICommand<TResult> {
    TResult Execute();
}

// Mediatar
public class CommandInvoker {
    public TResult Invoke<TResult>(ICommand<TResult> command) {
        return command.Execute();
    }
}

// Concrete Command
public class CommandReturnString : ICommand<string> {
    public string Execute() => "Order Created";
}

public class CommandReturnNumber : ICommand<int> {
    public int Execute() => 10;
}