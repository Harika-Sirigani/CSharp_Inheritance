using System;

class Vehicle {
    public required string Brand {get; set;}
    public int Speed {get; set;}

    
public void DisplayInfo() {
    Console.WriteLine($"Brand : {Brand} , Speed : {Speed} km/h");
}
}

class Car : Vehicle {
    public int NumberOfDoors {get;set;}

}

class Bike : Vehicle {
    public bool HasGear { get;set;}

}



