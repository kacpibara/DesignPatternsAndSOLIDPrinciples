// Polymorphism

// Poly = many

// Morph = forms

// Polymorphism is the ability of an object to take many forms.

using System.Security.AccessControl;

using DesignPatternsInCssharp.OopPrinciples.Polymorphism;

public class PolymorphismDemo
{
    public static void Run()
    {
        List <Vehicle> vehicles = new List<Vehicle>();
        //List <object> vehicles = new List<object>();

        vehicles.Add(new Car{ Brand = "Toyota", Model = "Camry", NumberOfWheels = 4, NumberOfDoors = 4});
        vehicles.Add(new Plane{ Brand = "Boeing", Model = "747", NumberOfWings = 2, NumberOfWheels = 6});
        vehicles.Add(new Motorcycle{ Brand = "Harley-Davidson", Model = "Sportster", HasSidecar = true, NumberOfWheels = 2});
            
        foreach(var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Stop();
        }

        // foreach(var vehicle in vehicles)
        // {
        //     if(vehicle is Car)
        //     {
        //         var car = (Car)vehicle;
        //         car.Start();
        //         car.Stop();
        //     }else if(vehicle is Plane)
        //     {
        //         var plane = (Plane)vehicle;
        //         plane.Start();
        //         plane.Stop();
        //     }else if(vehicle is Motorcycle)
        //     {
        //         var motorcycle = (Motorcycle)vehicle;
        //         motorcycle.Start();
        //         motorcycle.Stop();
        //     }  
        // }
    }
}