namespace DesignPatternsInCssharp.OopPrinciples.Inheritance;

// Inheritance

// Inheritance involves creating new classes (subclasses or derived classes) based on existing classes (superclasses or base classes).
// Subclasses inherit properties and behaviors from their superclasses and can also add new features or override existing ones. Inheritance is
// often described in terms of an "is-a" relationship.

public class InheritanceDemo()
{
    public static void Run()
    {
        System.Console.WriteLine("Bad Inheritance Demo");

        var car = new Car();

        // Shared 
        car.Brand = "Toyota";
        car.Model = "Camry";
        car.NumberOfWheels = 4;


        car.Start();
        car.Stop();

        // Unique
        car.NumberOfDoors = 4;

        var bike = new Bike();

        // Shared
        bike.Brand = "Honda";
        bike.Model = "CBR";
        bike.NumberOfWheels = 2;


        bike.Start();
        bike.Stop();

        // Unique
        bike.HasKickstand = true;


    }
}