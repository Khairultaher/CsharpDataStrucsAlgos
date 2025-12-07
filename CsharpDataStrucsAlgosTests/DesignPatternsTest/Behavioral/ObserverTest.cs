using CsharpDataStrucsAlgos.DesignPatterns;
using CsharpDataStrucsAlgos.DesignPatterns.Behavioral;
using CsharpDataStrucsAlgosTest.Helpers;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgosTest.DesignPatterns.Behavioral;

public class ObserverTest {

    [Fact]
    public void ObserverShouldReceiveNotifications() {
        // Arrange
        var subject = new Subject();
        var observer1 = new Observer("Observer1");
        var observer2 = new Observer("Observer2");

        observer1.Subscribe(subject);
        observer2.Subscribe(subject);

        using var consoleOutput = new ConsoleOutput();

        // Act
        subject.Update("Hello Observers!");

        // Assert
        var output = consoleOutput.GetOutput();

        output.ShouldContain("Observer1 received: Hello Observers!");
        output.ShouldContain("Observer2 received: Hello Observers!");
    }

}
