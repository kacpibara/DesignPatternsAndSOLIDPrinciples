
namespace DesignPatternsInCssharp.OopPrinciples.Abstraction;

public class BadEmailService
{
    public void SendEmail()
    {
        System.Console.WriteLine("Sending email...");
    }

    public void Connect()
    {
        System.Console.WriteLine("Connecting to email server...");
    }

    public void Authenticate()
    {
        System.Console.WriteLine("Authenticating...");
        
    }

    public void Disconect()
    {
        System.Console.WriteLine("Disconnecting from email server...");
    
    }
    
}