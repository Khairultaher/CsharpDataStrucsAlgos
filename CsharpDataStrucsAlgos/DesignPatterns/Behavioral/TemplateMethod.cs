namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
/// Usage in .NET: To implement data processing workflows where the steps are fixed, but some details vary(e.g., exporting data to different formats).
/// </summary>
public abstract class DataExporter {
    public void Export() {
        ReadData();
        ProcessData();
        WriteData();
    }
    protected abstract void ReadData();
    protected abstract void ProcessData();
    protected abstract void WriteData();
}

public class CsvDataExporter : DataExporter {
    protected override void ReadData() => Console.WriteLine("Reading CSV data");
    protected override void ProcessData() => Console.WriteLine("Processing CSV data");
    protected override void WriteData() => Console.WriteLine("Writing CSV data");
}

