
/// <summary>
/// The IOrderNotification interface defines the contract for sending order notifications.
/// It follows the Interface Segregation Principle by only including methods related to order notifications.
/// </summary>

public interface IOrderNotification
{
    void SendOrderConfirmation();
}
