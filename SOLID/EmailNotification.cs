
/// <summary>
/// The EmailNotification class implements the IOrderNotification interface.
/// It follows ISP by only implementing the functionality needed for sending email notifications.
/// </summary>

public class EmailNotification : IOrderNotification
{
    public void SendOrderConfirmation()
    {
        Console.WriteLine("Order confirmation sent via Email.");
    }
}
