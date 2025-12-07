using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CsharpDataStrucsAlgos.DesignPatterns.Structural;

/// <summary>
/// Intent: Use sharing to support a large number of fine-grained objects efficiently.
/// Usage in .NET: When many similar objects are used, such as icons or font characters in a document editor.
/// </summary>
public class Icon {
    public string Name { get; }
    public Icon(string name) { Name = name; }
    public void Draw(int x, int y) => Console.WriteLine($"Drawing {Name} at ({x}, {y})");
}

public class IconFactory {
    private readonly Dictionary<string, Icon> _icons = new Dictionary<string, Icon>();
    public Icon GetIcon(string name) {
        if (!_icons.ContainsKey(name))
            _icons[name] = new Icon(name);
        return _icons[name];
    }
}

