using CsharpDataStrucsAlgos.DesignPatterns;
using CsharpDataStrucsAlgosTest.Helpers;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgosTest;

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
