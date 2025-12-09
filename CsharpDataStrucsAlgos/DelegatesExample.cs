using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos;

delegate void MessagePrinter();
delegate void MessageWithParamPrinter(string message);
public class EventsDelegates {
    public void InvokeDelegateExample() {
        // Declare a variable of the delegate type
        // and make it point to a method
        MessagePrinter printer = new MessagePrinter(PrintHelloWorld);

        // Instead of using a constructor, we can just initialize it
        // with a method pointer
        MessagePrinter printer2 = PrintHelloWorld;

        // Add another method to which the delegate will point to
        printer += PrintGoodBye;
        printer2 += PrintGoodBye;

        // Call the delegate
        printer();

        // Another way to call the delegate
        printer2.Invoke();
    }

    // Returns void and does not accept any parameters
    static void PrintHelloWorld() {
        Console.WriteLine("Hello World!");
    }

    // Returns void and does not accept any parameters
    static void PrintGoodBye() {
        Console.WriteLine("Good bye!");
    }

    // combined delegate with parameters example
    public void InvokeDelegateWithParamExample() {
        // Create delegates of the same type
        MessageWithParamPrinter printer1 = SurroundWithHyphens;
        MessageWithParamPrinter printer2 = SurroundWithStars;
        MessageWithParamPrinter printer3 = SurroundWithStars;

        // Combine the delegates
        MessageWithParamPrinter printer4 = printer1 + printer2 + printer3;

        // Call the delegate
        printer4("Hello World!");
    }

    static void SurroundWithStars(string message) {
        Console.WriteLine($"***{message}***");
    }

    static void SurroundWithHyphens(string message) {
        Console.WriteLine($"---{message}---");
    }
}
