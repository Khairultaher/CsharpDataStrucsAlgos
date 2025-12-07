using System.Reflection.Metadata;

namespace CsharpDataStrucsAlgos.DesignPatterns.Creational;

/// <summary>
/// Intent: Separate the construction of a complex object from its representation so that the same construction process can create different representations.
/// Usage in .NET: Building complex objects like configuring a custom query or assembling a document.
/// </summary>


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

