using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Structural;

/// <summary>
/// Intent: Provide a surrogate or placeholder for another object to control access to it.
/// Usage in .NET: To implement lazy loading, caching, or access control for remote services(e.g., Entity Framework’s proxy objects).
/// </summary>
public interface IDataService {
    string GetData();
}

public class RealDataService : IDataService {
    public string GetData() => "Real Data";
}

public class DataServiceProxy : IDataService {
    private RealDataService _realService;
    public string GetData() {
        if (_realService == null)
            _realService = new RealDataService();
        // Additional logging, security, etc.
        return _realService.GetData();
    }
}
