using DesignPatternsInCssharp.OopPrinciples.Abstraction;

// Abstraction

// Reduce complexity by hiding unnecessary details
public class AbstractionDemo
{
    public static void Run()
    {
        System.Console.WriteLine("Bad Email Service");
        // Bad Email Service

        BadEmailService badEmailService = new BadEmailService();

        badEmailService.Connect(); 
        badEmailService.Authenticate();
        badEmailService.SendEmail();
        badEmailService.Disconect();

        // Good Email Service

        System.Console.WriteLine("Good Email Service");
        EmailService goodEmailService = new EmailService();
        goodEmailService.SendEmail();
    }
}
