using System.Collections;

namespace CsharpDataStrucsAlgos;

public class HasingExample {
    Hashtable hashtable = new Hashtable();
    public HasingExample() {
        hashtable.Add("txt", "notepad.exe");
        hashtable.Add("bmp", "paint.exe");
        hashtable.Add("dib", "paint.exe");
        hashtable.Add("rtf", "wordpad.exe");
        hashtable.Add("other", 1);

        ICollection keys = hashtable.Keys;
    }

}
