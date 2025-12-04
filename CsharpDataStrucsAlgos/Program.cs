using CsharpDataStrucsAlgos;


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

TaskThread taskThread = new TaskThread();
await taskThread.RunTaskWithCancelationTokenAsync();

#endregion Recursion

Console.ReadKey();