
namespace DesignPatternsInCssharp.OopPrinciples.Abstraction;

public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        System.Console.WriteLine("Sending email...");
        Disconect();
    }

    private void Connect()
    {
        System.Console.WriteLine("Connecting to email server...");
    }

    private void Authenticate()
    {
        System.Console.WriteLine("Authenticating...");
        
    }

    private void Disconect()
    {
        System.Console.WriteLine("Disconnecting from email server...");
    
    }
    
}