using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Define a family of algorithms, encapsulate each one, and make them interchangeable.
/// Usage in .NET: For example, choosing different compression or encryption strategies at runtime.
/// </summary>
public interface ICompressionStrategy {
    void Compress(string fileName);
}

public class ZipCompressionStrategy : ICompressionStrategy {
    public void Compress(string fileName) =>
        Console.WriteLine("Compressing using ZIP approach");
}

public class RarCompressionStrategy : ICompressionStrategy {
    public void Compress(string fileName) =>
        Console.WriteLine("Compressing using RAR approach");
}

public class CompressionContext {
    private ICompressionStrategy _strategy;
    public void SetStrategy(ICompressionStrategy strategy) => _strategy = strategy;
    public void CreateArchive(string fileName) => _strategy.Compress(fileName);
}

