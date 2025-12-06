namespace CsharpDataStrucsAlgos.DesignPatterns;

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