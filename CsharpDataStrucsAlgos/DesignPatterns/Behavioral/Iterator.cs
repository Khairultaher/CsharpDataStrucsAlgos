using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
/// Usage in .NET: .NET’s built-in IEnumerable<T> and IEnumerator<T> support iteration over custom collections.
/// </summary>
/// <typeparam name="T"></typeparam>
public class CustomCollection<T> : IEnumerable<T> {
    private readonly List<T> _items = new List<T>();
    public void Add(T item) => _items.Add(item);
    public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

