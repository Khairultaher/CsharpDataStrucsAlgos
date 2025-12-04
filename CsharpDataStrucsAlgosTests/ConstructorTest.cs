using CsharpDataStrucsAlgos;
using Shouldly;

namespace CsharpDataStrucsAlgosTest;

public class ConstructorTest {

    [Fact]
    public void ConstructorInitializationTest() {
        // Arrange
        int expectedNumber = 50;

        // Act
        var exampleEmpty = new ConstructorExample();
        var exampleInt = new ConstructorExample(expectedNumber);

        // Assert
        ConstructorExample.readonlyIntField.ShouldBe(40); // it is initialized with value 40
        exampleInt.intField.Equals(expectedNumber);
        ConstructorBaseExample.baseStaticIntField.ShouldBe(30); // it is initialized with value 30
        exampleInt.baseIntField.ShouldBe(80); // it is initialized with value 30, 30 + 50
    }
}
