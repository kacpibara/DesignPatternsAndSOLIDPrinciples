namespace DesignPatternsInCssharp.OopPrinciples.Polymorphism;


public class Plane : Vehicle
{
    public int NumberOfWings { get; set; }

    public override void Start()
    {
        Console.WriteLine("Plane is starting");
    }

    public override void Stop()
    {
        Console.WriteLine("Plane is stopping");
    }
}
