namespace CsharpDataStrucsAlgos;

internal class MyGenericClass<T1, T2>
    where T1 : class, new() // T1 must be a reference type and have a parameterless constructor
    where T2 : struct // T2 must be a value type
    {

    // Adding a type constraint for a generic method
    static void ClearReference<T1>(ref T1 param) {
        param = default(T1);
    }
}
