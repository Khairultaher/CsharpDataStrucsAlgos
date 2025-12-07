using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgosTest.DesignPatterns.Structural;

using CsharpDataStrucsAlgos.DesignPatterns.Structural;
using CsharpDataStrucsAlgosTest.Helpers;
using System;
using Xunit;

public class DecoratorTests {
    [Fact]
    public void BasicService_ShouldReturnBasicOperation() {
        // Arrange
        IService service = new BasicService();

        // Act
        var result = service.Operation();

        // Assert
        Assert.Equal("Basic Operation", result);
    }

    [Fact]
    public void LoggingDecorator_ShouldCallWrappedService() {
        // Arrange
        var service = new BasicService();
        IService decorated = new LoggingDecorator(service);

        // Act
        var result = decorated.Operation();

        // Assert
        Assert.Equal("Basic Operation", result);
    }

    [Fact]
    public void LoggingDecorator_ShouldWriteLogBeforeOperation() {
        // Arrange
        var service = new BasicService();
        IService decorated = new LoggingDecorator(service);

        using var consoleOutput = new ConsoleOutput();

        // Act
        decorated.Operation();

        // Assert
        Assert.Contains("Logging before operation", consoleOutput.GetOutput());
    }
}

