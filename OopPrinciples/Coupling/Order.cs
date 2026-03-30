namespace DesignPatternsInCssharp.OopPrinciples.Coupling;

public class Order
{
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }
    public void PlaceOrder()
    {
        // Place order logic ...
        
        // EmailSender emailSender = new EmailSender();
        // emailSender.SendNotification("Your Order placed successfuly");

        notificationService.SendNotification("Your Order placed successfuly");
    
    }

}

