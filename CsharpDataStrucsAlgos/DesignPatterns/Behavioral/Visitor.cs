namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Represent an operation to be performed on the elements of an object structure, letting you define a new operation without changing the classes of the elements.
/// Usage in .NET: For operations on a composite object structure(e.g., traversing a document tree and performing reporting or validation).
/// </summary>

// Visitor Interface
public interface Visitor {
    void Visit(Element element);
}

// Element Interface
public abstract class Element {
    public abstract void Accept(Visitor visitor);
}

// Concrete Element
public class ConcreteElement : Element {
    public string Name { get; set; }
    public override void Accept(Visitor visitor)
        => visitor.Visit(this);
}

public class ConcreteVisitor : Visitor {
    public void Visit(Element element) {
        if (element is ConcreteElement ce) {
            ce.Name = $"Visited";
        }
    }
}