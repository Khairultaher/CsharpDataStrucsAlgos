namespace CsharpDataStrucsAlgos;

public class Recursion {

    public void CalculateIteratively(int num) {
        while (num > 0) {
            int k = num * num;
            Console.WriteLine($"Iterative squire is: {k}");
            num--;
        }
    }

    public void CalculateTailRecursively(int num) {
        if (num > 0) {
            int k = num * num;
            Console.WriteLine($"Recursively squire is: {k}");
            CalculateTailRecursively(num - 1);
        }
    }

    public void CalculateHeadRecursively(int num) {
        if (num > 0) {
            CalculateHeadRecursively(num - 1);
            int k = num * num;
            Console.WriteLine($"Recursively squire is: {k}");
        }
    }

    public int Factorial(int num) {
        if (num <= 1) {
            return 1;
        }
        return num * Factorial(num - 1);
    }

    public int BinarySearchRecursive(int[] arr, int target, int left, int right) {
        if (left > right)
            return -1; // target not found

        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            return mid;
        else if (arr[mid] < target)
            return BinarySearchRecursive(arr, target, mid + 1, right);
        else
            return BinarySearchRecursive(arr, target, left, mid - 1);
    }
}