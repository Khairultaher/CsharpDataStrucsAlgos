using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos;

public class Calculator {

    public double Product(double x, double y) {
        return x * y;
    }

    // Overloading the function to handle three arguments
    public double Product(double x, double y, double z) {
        return x * y * z;
    }

    // Overloading the function to handle int
    public int Product(int x, int y) {
        return x * y;
    }
}
