using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos;

public class ConstructorExample: ConstructorBaseExample {

    public readonly int intField;
    public static readonly int readonlyIntField;
    public const int constIntField = 100;
    public ConstructorExample() {
        // This will cause a compile-time error
        // because const fields cannot be assigned a value outside their declaration.

        //constIntField = 20; 
    }

    static ConstructorExample() {
        readonlyIntField = 40;
    }

    public ConstructorExample(int value): base(value) {

        intField = value;
    }

}

public class ConstructorBaseExample {

    public int baseIntField;
    public static readonly int baseStaticIntField;
    public ConstructorBaseExample() {
        baseIntField = 10;
    }

    static ConstructorBaseExample() {
        baseStaticIntField = 30;
    }
    public ConstructorBaseExample(int value) {

        baseIntField = baseStaticIntField + value;
    }

}
