using CsharpDataStrucsAlgos;
using System.Diagnostics;


// Adding a type constraint for a generic method
static void ClearReference<T>(ref T param) where T : class {
    param = default(T);
}
#region Recursion

//var rec = new Recursion();

//rec.CalculateIteratively(5);

//Console.WriteLine("--------------");

//rec.CalculateHeadRecursively(5);

//Console.WriteLine("--------------");

//rec.CalculateTailRecursively(5);

Debug.WriteIf(1 == 1 ,"------Output Message--------");
Debug.Assert(1 != 1, "Assertion Failed...");

TaskThread taskThread = new TaskThread();
await taskThread.RunTaskWithCancelationTokenAsync();

#endregion Recursion

Console.ReadKey();