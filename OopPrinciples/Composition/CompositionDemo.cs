// Composition

// Composition involves creating complex objects by combining simpler objects or components.
// In composition, objects are assembled together to form larger strcutures, witch each component 
// object maintaining its own state and behavvior. Composition is often described in terms of a 
// "has-a" relationship.

namespace DesignPatternsInCssharp.OopPrinciples.Composition;

public class CompositionDemo
{
    public static void Run()
    {
        Car car = new Car();
        car.Start();
    }
}