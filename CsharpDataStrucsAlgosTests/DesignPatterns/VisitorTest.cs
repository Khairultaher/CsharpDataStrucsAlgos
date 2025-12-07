using CsharpDataStrucsAlgos.DesignPatterns;
using CsharpDataStrucsAlgos.DesignPatterns.Behavioral;
using Shouldly;

namespace CsharpDataStrucsAlgosTest.DesignPatterns;

public class VisitorTest {
    [Fact]
    public void TestVisitorPattern() {
        // Arrange
        var element = new ConcreteElement { Name = "TestElement" };
        var visitor = new ConcreteVisitor();

        // Act
        element.Accept(visitor);

        // Assert
        element.Name.ShouldBe("Visited");
    }
}
