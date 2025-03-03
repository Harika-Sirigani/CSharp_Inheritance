using System;

class Vehicle1 {
    public required string Brand {get;set;}
    public int Speed {get;set;}

    public virtual void DisplayInfo() {
        Console.WriteLine($"Brand : {Brand} , Speed : {Speed} km/h");

    }
}

class Car1 : Vehicle1 {
    public int NumberOfDoors {get; set;}

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"No of Doors : {NumberOfDoors}");
    }
}

class Bike1 : Vehicle1 {
    public bool HasGear{get;set;}

    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Calling base class method
        Console.WriteLine($"HAsgear : {HasGear}");
    }
}