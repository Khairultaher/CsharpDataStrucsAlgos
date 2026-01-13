namespace CsharpDataStrucsAlgos.Educative_99;

public class DynamicPrograming {

    public int FindFibonacci(int n) {
        if (n <= 1) {
            return n;
        }
        int[] fib = new int[n + 1];
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 2; i <= n; i++) {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        return fib[n];
    }

    public int RecursiveFindFibonacci(int n, Dictionary<int, int> memo = null) {
        if (memo == null) {
            memo = new Dictionary<int, int>();
        }
        if (n <= 1) {
            return n;
        }
        if (memo.ContainsKey(n)) {
            return memo[n];
        }
        memo[n] = RecursiveFindFibonacci(n - 1, memo) 
            + RecursiveFindFibonacci(n - 2, memo);
        return memo[n];
    }

    public int FindTribonacci(int n) {
        if (n < 3) {
            return n == 0 ? 0 : 1;
        }
        int first = 0, second = 1, third = 1, next = 0;
        for (int i = 3; i <= n; i++) {
            next = first + second + third;
            first = second;
            second = third;
            third = next;
        }
        return third;
    }

    public int RecursiveFindTribonacci(int n, Dictionary<int, int> memo = null) {
        if (memo == null) {
            memo = new Dictionary<int, int>();
        }
        if (n < 3) {
            return n == 0 ? 0 : 1;
        }
        if (memo.ContainsKey(n)) {
            return memo[n];
        }
        memo[n] = RecursiveFindTribonacci(n - 1, memo) 
            + RecursiveFindTribonacci(n - 2, memo) 
            + RecursiveFindTribonacci(n - 3, memo);
        return memo[n];
    }

    public int[] CountingBits(int n) {
        int[] restult = new int[n + 1];
        if (n == 0) {
            return restult;
        }
        restult[0] = 0;
        restult[1] = 1;
        for (int i = 2; i < n; i++) {
            if (i % 2 == 0) { 
                restult[i] = restult[i / 2];
            } else {
                restult[i] = restult[i / 2] + 1;
            }
        }
        return restult;
    }
}
