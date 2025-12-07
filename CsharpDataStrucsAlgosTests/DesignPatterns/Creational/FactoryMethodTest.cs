using CsharpDataStrucsAlgos.DesignPatterns.Creational;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgosTest.DesignPatterns.Creational;

public class FactoryMethodTest {
    [Fact]
    public void FactoryShouldReturnConcreteObject() {

        // arrange
        DataAccessFactory factory;

        // Choose SQL factory
        // act
        factory = new SqlDataAccessFactory();
        DataAccess sql = factory.CreateDataAccess();      
        sql.Connect(); // Expected output: "Connected to SQL Server"

        // assert
        Assert.IsType<SqlDataAccess>(sql);


        // Choose Oracle factory
        // act 
        factory = new OracleDataAccessFactory();
        DataAccess oracle = factory.CreateDataAccess();
        oracle.Connect(); // Expected output: "Connected to Oracle"

        //assert
        Assert.IsType<OracleDataAccess>(oracle);

    }
}