using CsharpDataStrucsAlgos.DesignPatterns;
using Shouldly;

namespace CsharpDataStrucsAlgosTest;

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
