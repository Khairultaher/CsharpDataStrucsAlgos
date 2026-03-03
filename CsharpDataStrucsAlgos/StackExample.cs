using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos;

public class StackExample {
    public static int EvaluatePostFix(string exp) {
        Stack<int> ints = new Stack<int>();
        char charectar;
        int val1, val2;

        for (int i = 0; i < exp.Length; i++) {

            charectar = exp[i];
            if (!Char.IsDigit(charectar)) {
                val1 = ints.Pop();
                val2 = ints.Pop();
                var res = charectar switch {
                    '+' => val2 + val1,
                    '-' => val2 - val1,
                    '*' => val2 * val1,
                    '/' => val2 / val1,
                    _ => 0
                };
                ints.Push(res);
            }
            else {
                ints.Push(charectar - '0');
            }
        }

        return ints.Pop();
    }

    public static int[] NextGreaterElement(int[] arr) {
        int n = arr.Length;
        Stack<int> stack = new Stack<int>();
        int next, top;
        int[] res = new int[n];
        for (int i = n - 1; i >= 0; i--) {
            next = arr[i]; // potential next greater element
            if (stack.Count > 0)
                top = stack.Peek();
            else
                top = -1;

            while (stack.Count > 0 && top <= next) {
                stack.Pop();
                if (stack.Count > 0)
                    top = stack.Peek();
                else
                    top = -1;
            }

            if(stack.Count > 0)
                res[i] = stack.Peek();
            else
                res[i] = -1;

            // push this element to stack for next iteration
            stack.Push(next);
        } // end of for

        return res;
    }

    public  static bool IsBalanced(string exp) {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in exp) {
            if (ch == '(' || ch == '{' || ch == '[') {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']') {
                if (stack.Count == 0) {
                    return false;
                }
                char top = stack.Pop();
                if ((ch == ')' && top != '(') ||
                    (ch == '}' && top != '{') ||
                    (ch == ']' && top != '[')) {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
