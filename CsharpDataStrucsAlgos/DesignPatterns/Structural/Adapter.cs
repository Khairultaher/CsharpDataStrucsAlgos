using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Structural;

// Adaptee (legacy class)
public class LegacyLogger {
    public void LogMessage(string msg) => Console.WriteLine("Legacy Log: " + msg);
}

// Target Interface
public interface ILogger {
    void Log(string message);
}

// Adapter
public class LoggerAdapter : ILogger {
    private readonly LegacyLogger _legacyLogger;
    public LoggerAdapter(LegacyLogger legacyLogger) { _legacyLogger = legacyLogger; }
    public void Log(string message) => _legacyLogger.LogMessage(message);
}
