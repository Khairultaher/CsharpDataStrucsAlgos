using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

/// <summary>
/// Intent: Ensure a class has only one instance and provide a global point of access.
/// Usage in .NET: For services like logging, configuration managers, or database connection pools.
/// </summary>
public sealed class Singleton {
    private static readonly Lazy<Singleton> 
        _instance = new Lazy<Singleton>(() => new Singleton());

    public static Singleton Instance => _instance.Value;

    private Singleton() { }
}

