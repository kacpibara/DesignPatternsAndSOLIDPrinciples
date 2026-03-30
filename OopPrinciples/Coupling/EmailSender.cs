namespace DesignPatternsInCssharp.OopPrinciples.Coupling;

public class EmailSender : INotificationService
{
    public void SendNotification(string message)
    {
        // Email senging logic
        System.Console.WriteLine("Sending email: " + message);
    }

}