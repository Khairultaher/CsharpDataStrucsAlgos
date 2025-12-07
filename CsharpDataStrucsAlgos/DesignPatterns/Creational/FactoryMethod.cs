using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

/// <summary>
/// Intent: Define an interface for creating an object but let subclasses decide which class to instantiate.
/// Usage in .NET: To create data access objects(DAOs) or service instances based on configuration.
/// </summary>

// Product
public abstract class DataAccess {
    public abstract void Connect();
}

// Concrete Products
public class SqlDataAccess : DataAccess {
    public override void Connect() => Console.WriteLine("Connected to SQL Server");
}

public class OracleDataAccess : DataAccess {
    public override void Connect() => Console.WriteLine("Connected to Oracle");
}

// Creator
public abstract class DataAccessFactory {
    public abstract DataAccess CreateDataAccess();
}

// Concrete Creator 1
public class SqlDataAccessFactory : DataAccessFactory {
    public override DataAccess CreateDataAccess() => new SqlDataAccess();
}

// Concrete Creator 2
public class OracleDataAccessFactory : DataAccessFactory {
    public override DataAccess CreateDataAccess() => new OracleDataAccess();
}



