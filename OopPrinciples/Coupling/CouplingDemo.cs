namespace DesignPatternsInCssharp.OopPrinciples.Coupling;

public class CouplingDemo
{
    public static void Run()
    {
        // Coupling

        // The degree of dependency between different classes
        
        var orderFirst = new Order(new EmailSender());
        orderFirst.PlaceOrder();

        var orderOther = new Order(new SmsSender());
        orderOther.PlaceOrder();
    
    }
}