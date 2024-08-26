
/// <summary>
/// The OrderProcessor class demonstrates the Dependency Inversion Principle by depending on abstractions (IOrderNotification and IOrderPayment)
/// instead of concrete implementations. This allows for greater flexibility and makes the system easier to extend and modify.
/// </summary>

public class OrderProcessor
{
    private readonly IOrderNotification _notification;
    private readonly IOrderPayment _payment;

    public OrderProcessor(IOrderNotification notification, IOrderPayment payment)
    {
        _notification = notification;
        _payment = payment;
    }

    public void ProcessOrder()
    {
        _payment.ProcessPayment();
        _notification.SendOrderConfirmation();
    }
}
