namespace CsharpDataStrucsAlgos.DesignPatterns.Behavioral;

/// <summary>
/// Intent: Capture and externalize an object’s internal state without violating encapsulation, so that the object can be restored later.
/// Usage in .NET: Implementing undo/redo functionality in applications.
/// </summary>
internal interface IMemento {
    string GetState();
    DateTimeOffset GetCreatedDate();
}

internal class TextEditorMemento : IMemento {
    private readonly string state;
    private readonly DateTimeOffset created;

    public TextEditorMemento(string state) {
        this.state = state;
        created = DateTimeOffset.Now;
    }
    public string GetState() {
        return state;
    }
    public DateTimeOffset GetCreatedDate() {
        return created;
    }
}

internal class TextEditor {
    private string state;

    public TextEditor() {
        state = string.Empty;
    }
    public string GetCurrentText() {
        return state;
    }
    public void UpdateText(string updatedText) {
        state = updatedText;
    }
    public IMemento Save() {
        Console.WriteLine("Saving state.");
        return new TextEditorMemento(state);
    }
    public void SetState(IMemento memento) {
        state = memento.GetState();
        Console.WriteLine($"Restored the state from the snapshot created at {memento.GetCreatedDate()}.");
    }
}


internal class Caretaker {
    private TextEditor textEditor;
    private Stack<IMemento> history;

    public Caretaker(TextEditor textEditor) {
        this.textEditor = textEditor;
        history = new Stack<IMemento>();
    }
    public void Backup() {
        history.Push(textEditor.Save());
    }
    public void Revert() {
        Console.WriteLine("Restoring a snapshot from history.");
        if (history.Count == 0) {
            Console.WriteLine("No snapshots to restore.");
            return;
        }
        textEditor.SetState(history.Pop());
    }
}

/*
 
var textEditor = new TextEditor();

var caretaker = new Caretaker(textEditor);

textEditor.UpdateText("Original text.");

Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");

caretaker.Backup();
textEditor.UpdateText("First edit.");

Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");
caretaker.Backup();

textEditor.UpdateText("Second edit.");

Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");

caretaker.Backup();

textEditor.UpdateText("Third edit.");

Console.WriteLine($"Updated text to '{textEditor.GetCurrentText()}'.");
caretaker.Revert();

Console.WriteLine($"Reverted text to '{textEditor.GetCurrentText()}'.");

caretaker.Revert();
Console.WriteLine($"Reverted text to '{textEditor.GetCurrentText()}'.");
caretaker.Revert();
Console.WriteLine($"Reverted text to '{textEditor.GetCurrentText()}'.");
Console.WriteLine("Press any key to exit...");
 
 */
