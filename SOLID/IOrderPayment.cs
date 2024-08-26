
/// <summary>
/// The IOrderPayment interface defines the contract for processing payments.
/// It follows the Interface Segregation Principle by only including methods related to payment processing.
/// </summary>

public interface IOrderPayment
{
    void ProcessPayment();
}
