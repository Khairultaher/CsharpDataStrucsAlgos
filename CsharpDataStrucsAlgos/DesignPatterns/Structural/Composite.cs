using CsharpDataStrucsAlgos.DesignPatterns.Creational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Structural;
/// <summary>
/// Intent: Compose objects into tree structures to represent part-whole hierarchies.
/// Usage in .NET: Building UI component trees(e.g., panels containing buttons and other controls).
/// </summary>
internal interface IComponent {
    string Name {
        get;
    }
    void Display(string currentPath);
}

internal class Folder : IComponent {
    private readonly List<IComponent> children;
    public Folder(string name) {
        Name = name;
        children = new();
    }
    public string Name {
        get;
    }
    public void Display(string currentPath) {
        Console.WriteLine(currentPath + Name + Path.DirectorySeparatorChar);
    }
    public void Add(IComponent child) {
        children.Add(child);
    }
    public void Remove(string name) {
        var childToRemove = children.FirstOrDefault(c => c.Name == name);
        if (childToRemove is not null) children.Remove(childToRemove);
    }
    public void DisplayChildren(string path) {
        foreach (var item in children) {
            item.Display(path + Name + Path.DirectorySeparatorChar);
            if (item is Folder folder) {
                folder.DisplayChildren(path + Name + Path.DirectorySeparatorChar);
            }
        }
    }
}

internal class File : IComponent {
    public File(string name) {
        Name = name;
    }
    public string Name {
        get;
    }
    public void Display(string currentPath) {
        Console.WriteLine(currentPath + Name);
    }
}