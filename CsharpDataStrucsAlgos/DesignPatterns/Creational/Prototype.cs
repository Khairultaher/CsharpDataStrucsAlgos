using System.Numerics;
using System.Runtime.InteropServices;

namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

/// <summary>
/// Intent: Specify the kinds of objects to create using a prototypical instance and create new objects by copying this prototype.
/// Usage in .NET: When you need to duplicate objects—such as cloning configuration settings or complex objects.
/// </summary>
public interface ICloneable {
    ICloneable Clone();
}


public class CloneableObject : ICloneable {
    private readonly int internalData;
    private readonly string internalTitle;

    public CloneableObject(string title) {
        var random = new Random();
        internalData = random.Next();
        internalTitle = title;
    }
    public int Data => internalData;
    public string Title => internalTitle;
    public ICloneable Clone() {
        return (CloneableObject)MemberwiseClone();
    }
}
