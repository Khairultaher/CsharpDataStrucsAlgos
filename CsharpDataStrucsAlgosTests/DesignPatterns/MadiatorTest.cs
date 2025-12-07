using CsharpDataStrucsAlgos.DesignPatterns.Behavioral;
using CsharpDataStrucsAlgosTest.Helpers;
using Shouldly;

namespace CsharpDataStrucsAlgosTest.DesignPatterns;

public class MadiatorTest {
    [Fact]
    public void MadiatorShouldSendMeassgeProperly() {
        // Arrange
        var madiator = new ConcreteMediator();
        var colleague1 = new ConcreteColleague1(madiator);
        var colleague2 = new ConcreteColleague2(madiator);
        madiator.RegisterColleague(colleague1);
        madiator.RegisterColleague(colleague2);
        using var consoleOutput = new ConsoleOutput();
        // Act
        colleague1.Send("Hello from Colleague1");
        // Assert
        var output = consoleOutput.GetOutput();
        output.ShouldContain("Colleague2 received: Hello from Colleague1");
    }
}
