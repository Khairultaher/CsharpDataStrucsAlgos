using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos;

public class StackExample {
    public static int EvaluatePostFix(string exp) { 
        Stack<int> ints = new Stack<int>();
        char charectar;
        int val1, val2;

        for (int i = 0; i < exp.Length;  i++) {

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
}
