namespace CsharpDataStrucsAlgos.DesignPatterns;

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