using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns;

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
