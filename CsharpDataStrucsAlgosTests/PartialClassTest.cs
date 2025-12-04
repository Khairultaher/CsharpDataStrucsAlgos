using CsharpDataStrucsAlgos;

namespace CsharpDataStrucsAlgosTest;

public class PartialClassTest {

    [Fact]
    public void PartialClassInitializationTest() {
        // Arrange
        int expectedNumber = 42;
        string expectedText = "Hello, Partial Class!";

        // Act
        var exampleInt = new PartialClassExample(expectedNumber);
        var exampleText = new PartialClassExample(expectedText);

        // Assert
        exampleInt._exampleIntField.Equals(expectedNumber);
          exampleText._exampleTextField.Equals(expectedText);
    }
}
