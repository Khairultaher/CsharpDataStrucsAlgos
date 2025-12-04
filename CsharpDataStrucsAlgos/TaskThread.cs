namespace CsharpDataStrucsAlgos;

internal class TaskThread {

    public async Task RunTaskWithCancelationTokenAsync() {
        var cts = new CancellationTokenSource();
        var token = cts.Token;

        Task.Run(async () => {
            while (!token.IsCancellationRequested) {
                Console.WriteLine("Working...");
                await Task.Delay(1000);
            }
            Console.WriteLine("Task Cancelled");
        }, token);

        // Cancel after 3 seconds
        await Task.Delay(10000);
        cts.Cancel();
    }
}
