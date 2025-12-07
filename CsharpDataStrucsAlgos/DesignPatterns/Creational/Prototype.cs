using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

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
