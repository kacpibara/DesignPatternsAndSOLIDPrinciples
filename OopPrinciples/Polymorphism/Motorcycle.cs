namespace DesignPatternsInCssharp.OopPrinciples.Polymorphism;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void Start()
    {
        Console.WriteLine("Motorcycle is starting");
    }

    public override void Stop()
    {
        Console.WriteLine("Motorcycle is stopping");
    }
}

