/* Problem Statement: Vehicle Inheritance
Create a set of classes to model different types of vehicles using inheritance. You will have a base class Vehicle and three derived classes: Car, Motorcycle, and Truck.

1. The Vehicle class should have the following properties and methods:

Properties:
Make (string): The make of the vehicle.
Model (string): The model of the vehicle.
Year (int): The manufacturing year of the vehicle.
Methods:
StartEngine(): Displays a message indicating that the vehicle's engine has started.
StopEngine(): Displays a message indicating that the vehicle's engine has stopped.

2.The Car class should inherit from Vehicle and add the following properties and methods:

Properties:
NumberOfDoors (int): The number of doors the car has.
IsConvertible (bool): A boolean indicating whether the car is a convertible.
Methods:
HonkHorn(): Displays a message indicating that the car's horn has been honked.

3.The Motorcycle class should inherit from Vehicle and add the following properties and methods:

Properties:
IsSportBike (bool): A boolean indicating whether the motorcycle is a sport bike.
EngineDisplacementCC (int): The engine displacement in cubic centimeters.
Methods:
Wheelie(): Displays a message indicating that the motorcycle is performing a wheelie.

4. The Truck class should inherit from Vehicle and add the following properties and methods:

Properties:
PayloadCapacityKg (int): The payload capacity of the truck in kilograms.
NumberOfAxles (int): The number of axles the truck has.
Methods:
LoadCargo(): Displays a message indicating that the truck is loading cargo.
UnloadCargo(): Displays a message indicating that the truck is unloading cargo.


Create instances of each type of vehicle and demonstrate their properties and methods in a console application.

Your C# code should allow you to create instances of Car, Motorcycle, and Truck, set their properties, and call their methods to display appropriate messages.

Feel free to add additional properties or methods to enhance the exercise if desired.

Once you've implemented this exercise, you can test it by creating instances of each vehicle type, setting their properties, and invoking their methods to ensure that the inheritance and functionality are correctly implemented.
*/


public class Vehicle{
    
    //Properties.
    public int Year {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}

    //Methods.
    public void StartEngine(){
        Console.WriteLine("Engine has started.");
    }
    public void StopEngine(){
        Console.WriteLine("Engine has stopped.");
    }

    //Default Constructor 
    public Vehicle() {
        Year = 2012;
        Make = "Toyota";
        Model = "Camri";
    }

    //Instance Constructor
    public Vehicle(int year, string make, string model){
        this.Year = year;
        this.Make = make;
        this.Model = model;
    }

    //Virtual Method: a method intended to be overridden by derived classes
    public virtual void DisplayInformation(){
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
    }

}

public class Car : Vehicle{

    public int NumberOfDoors {get; set;}

    public bool IsConvertible {get; set;}

    public void HonkHorn(){

        Console.WriteLine("Horn was honked.");
    }

    public override void DisplayInformation()
    {
        base.DisplayInformation();
        Console.WriteLine($"Number of doors: {NumberOfDoors}");
        Console.WriteLine($"Convertible: {IsConvertible}");
    }

}

public class Motorcycle : Vehicle {

    public bool IsSportBike {get; set;}

    public int EngineDisplacement {get; set;}

    public void Wheelie(){
        Console.WriteLine("Motorcycle is performing a wheelie.");
    }

    //Constructor
    public Motorcycle(int year, string make, string model, bool type, int engine) : base(year, make, model){
        this.IsSportBike = type;
        this.EngineDisplacement = engine;
    }
}

public class Truck : Vehicle {
    public int PayloadCapacityKg {get; set;}

    public int NumberOfAxles {get; set;}

    public void LoadCargo(){
        Console.WriteLine("Truck is loading cargo.");
    }

    public void UnloadCargo(){
        Console.WriteLine("Truck is unloading cargo.");
    }

    //Default Constructor
    public Truck(){
        Year = 2020;
        Make = "Isuzu";
        Model = "FDR";
        PayloadCapacityKg = 1000;
        NumberOfAxles = 3;
    }

    //Instance Constructor
    public Truck(int year, string make, string model, int loadCapacity, int axles) : base (year, make, model){
        this.PayloadCapacityKg = loadCapacity;
        this.NumberOfAxles = axles;
    }

}

public class Program{
    
    static void Main(string[] args){

        Car myCar = new Car();
        myCar.Make = "Honda";
        myCar.Model = "HRV";
        myCar.Year = 2015;
        myCar.NumberOfDoors = 4;
        myCar.IsConvertible = false;

        Console.WriteLine($"Danielle's car is a {myCar.Year} {myCar.Make} {myCar.Model}. It has {myCar.NumberOfDoors} doors.");
        myCar.DisplayInformation();
        myCar.HonkHorn();

        Console.WriteLine("___________");

        Motorcycle myBike1 = new Motorcycle(2023, "BMW", "1000 RR", true, 300);
        Console.WriteLine($"{myBike1.Make} {myBike1.Model}");

        Console.WriteLine("___________");

        Truck newTruck = new Truck();
        Console.WriteLine($"{newTruck.Model}");

        Truck myTruck = new Truck(2021, "Isuzu", "FDR", 2000, 5);
        Console.WriteLine(myTruck.NumberOfAxles);

    }
}