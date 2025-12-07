using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

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



