namespace CsharpDataStrucsAlgos;

// Accept multiple type parameters
internal class MyGenericClass<T1, T2>
    where T1 : class, new() // T1 must be a reference type and have a parameterless constructor
    where T2 : struct // T2 must be a value type
    {

    // Adding a type constraint for a generic method
    static void ClearReference<T1>(ref T1 param) {
        param = default(T1);
    }

    // Generic method
    private static T GetDefault<T>() {
        return default(T);
    }
}


public abstract class Vehicle {
    public string Model { get; set; }
}

public class Car : Vehicle {
    public int TrunkCapacity { get; set; }
}

public class Truck {
    public int MaxCargoWeight { get; set; }
}

public class Garage<T> where T : Vehicle {
    public T[] Vehicles { get; private set; }

    public Garage(int garageSize) {
        Vehicles = new T[garageSize];
    }
}

//  generic tyype and inheritence
public class Holder<T> {
    public T[] Items { get; private set; }

    public Holder(int holderSize) {
        Items = new T[holderSize];
    }

    public override string ToString() {
        string result = "Items inside: ";

        foreach (var item in Items) {
            result = result + item + " ";
        }

        return result;
    }
}

// The same type parameter as the base class
public class BetterHolder<T> : Holder<T> {
    public T this[int index] {
        get {
            return this.Items[index];
        }

        set {
            this.Items[index] = value;
        }
    }

    public BetterHolder(int holderSize)
        : base(holderSize) {

    }
}

// This class is not generic, but it derives from a generic class
public class IntegerHolder : Holder<int> {
    public IntegerHolder(int holderSize)
        : base(holderSize) {

    }

    public int GetSum() {
        int sum = 0;

        foreach (var number in Items) {
            sum += number;
        }

        return sum;
    }
}

// This class inherits from a class that accepts only one type parameter
// But this class itself accepts two parameters
public class ExtendedHolder<T1, T2> : Holder<T1> {
    public T2[] Items2 { get; private set; }

    public ExtendedHolder(int firstContainerSize, int secondContainerSize)
        : base(firstContainerSize) {
        Items2 = new T2[secondContainerSize];
    }

    public override string ToString() {
        // Calling the ToString method from the base class
        var result = base.ToString();

        result += "\nSecond container items: ";

        foreach (var item in Items2) {
            result = result + item + " ";
        }

        return result;
    }
}