using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Define a one-to-many dependency so that when one object changes state, all its dependents are notified and updated automatically.
/// Usage in .NET: Event handling via delegates/events or implementing INotifyPropertyChanged in MVVM.
/// </summary>
public class Subject {
    public event Action<string> Notify;
    public void Update(string message) { 
        Notify?.Invoke(message);
    }
}

public class Observer { 
    private readonly string _name;
    public Observer(string name ){
        _name = name;
    }

    public void Subscribe(Subject subject) {
        subject.Notify += OnNotified;
    }

    private void OnNotified(string message) {
        Console.WriteLine($"{_name} received: {message}");
    }
}
