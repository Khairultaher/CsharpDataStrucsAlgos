using CsharpDataStrucsAlgos;
using Shouldly;

namespace CsharpDataStrucsAlgosTests;

public class RecursionTest {

    [Theory]
    [InlineData(new int[] { 1, 3, 5, 7, 9 }, 3)]
    public void BinarySearchRecursiveShouldReturnResult(int[] arr, int target) {
        // Arrange
        var searcher = new Recursion();
        int left = 0; int right = arr.Length - 1;

        // Act
        var index = searcher.BinarySearchRecursive(arr, target, left, right);

        // Assert
        arr[index].ShouldBe(target);
    }

    [Theory]
    [InlineData(new int[] { 1, 3, 5, 7, 9 }, 2)]
    public void BinarySearchRecursiveShouldNotReturnResult(int[] arr, int target) {
        // Arrange
        var searcher = new Recursion();
        int left = 0; int right = arr.Length - 1;

        // Act
        var index = searcher.BinarySearchRecursive(arr, target, left, right);

        // Assert
        index.ShouldBe(-1);
    }
}