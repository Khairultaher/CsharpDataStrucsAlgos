namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

/// <summary>
/// Intent: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
/// Usage in .NET: When building cross-platform UI frameworks(e.g., creating buttons, checkboxes for Windows vs. macOS).
/// </summary>


// Abstract Products
public interface IButton { void Render(); }
public interface ICheckbox { void Render(); }

// Concrete Products for Windows
public class WinButton : IButton { public void Render() => Console.WriteLine("Windows Button"); }
public class WinCheckbox : ICheckbox { public void Render() => Console.WriteLine("Windows Checkbox"); }

// Concrete Products for Linux
public class LinuxButton : IButton { public void Render() => Console.WriteLine("Linux Button"); }
public class LinuxCheckbox : ICheckbox { public void Render() => Console.WriteLine("Linux Checkbox"); }


// Abstract Factory
public interface IGUIFactory {
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}


// Concrete Windows Factory
public class WindowsFactory : IGUIFactory {
    public IButton CreateButton() => new WinButton();
    public ICheckbox CreateCheckbox() => new WinCheckbox();
}

// Concrete Linux Factory
public class LinuxFactory : IGUIFactory {
    public IButton CreateButton() => new WinButton();
    public ICheckbox CreateCheckbox() => new WinCheckbox();
}

