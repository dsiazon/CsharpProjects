public interface IVehicle{
    
    //Properties.
    public int Year {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}

    public int MPG {get;}

    //Methods.
    public void Start();

    public void Stop();

    public double computeMileage(int gallon);

}

public abstract class Car : IVehicle{
    //Properties.
    public int Year {get; set;}
    public string Make {get; set;}
    public string Model {get; set;}

    public int MPG {get;}

    const int milesPerGallon = 17;

    //Methods.
    public virtual void Start(){
        Console.WriteLine("Car has started.");
    }

    public virtual void Stop(){
        Console.WriteLine("Car has stopped.");
    }

    public double computeMileage(int gallon){
        return gallon * milesPerGallon;
    }

    public void OilChange(){
        Console.WriteLine("Car has oil changed.");
    }
        
}

public class Truck : Car{
    public override void Start(){
        Console.WriteLine("Truck has started.");
    }

    public override void Stop(){
        Console.WriteLine("Truck has stopped.");
    }
}

public class Sedan : Car{
    public double CurrentValue{get; set;}
    public double RemainingBalance{get; set;}

    private string color{get; set;}

    public override void Stop(){
        Console.WriteLine("Sedan has stopped.");
    }


}

public class SportsCar : Sedan, ITradeInfo {
    public string color{get; set;}

}

public interface ITradeInfo{
    public double CurrentValue{get; set;}
    public double RemainingBalance{get; set;}

    public string color{get; set;}
}

public class Program{
    
    static void Main(string[] args){
        Car myTruck = new Truck();

       // myTruck.Start();

        var mySportsCar = new SportsCar();

      //  mySedan.RemainingBalance = 1234.23;
      //  mySedan.Start();
        Stop(mySportsCar);

    }

    static void Stop(IVehicle Vehicle){
        Vehicle.Stop();
    }
}