using CsharpDataStrucsAlgos.DesignPatterns;
using Shouldly;

namespace CsharpDataStrucsAlgosTest;

public class CommandPatternTest {
    [Fact]
    public void TestCommandPattern() {
        // Arrange
        var invoker = new CommandInvoker();
        var stringCommand = new CommandReturnString();
        var numberCommand = new CommandReturnNumber();

        // Act
        var resultString = invoker.Invoke(stringCommand);
        var resultNumber = invoker.Invoke(numberCommand);

        // Assert
        resultString.ShouldBeOfType<string>();
        resultNumber.ShouldBeOfType<int>();

    }
}
