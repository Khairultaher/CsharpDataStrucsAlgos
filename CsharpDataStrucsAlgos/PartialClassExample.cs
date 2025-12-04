using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos;

public partial class PartialClassExample {
    public  int _exampleIntField;
    public PartialClassExample(int exampleIntField) {
        _exampleIntField = exampleIntField;
    }
}

public partial class PartialClassExample {
    public string _exampleTextField;
    public PartialClassExample(string exampleTextField) {
        _exampleTextField = exampleTextField;
    }
}
