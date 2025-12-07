using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

// Product the target object to be built
public class House {
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Door { get; set; }
}

// Builder Interface
public interface IHouseBuilder {
    void BuildWalls();
    void BuildRoof();
    void BuildDoor();
    House GetHouse();
}

// Concrete Builder
public class ConcreteHouseBuilder : IHouseBuilder {
    private House _house = new House();
    public void BuildWalls() { _house.Walls = "Concrete Walls"; }
    public void BuildRoof() { _house.Roof = "Concrete Roof"; }
    public void BuildDoor() { _house.Door = "Wooden Door"; }
    public House GetHouse() => _house;
}

// Director
public class Director {
    public void Construct(IHouseBuilder builder) {
        builder.BuildWalls();
        builder.BuildRoof();
        builder.BuildDoor();
    }
}

