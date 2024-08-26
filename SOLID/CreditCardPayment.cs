
/// <summary>
/// The CreditCardPayment class implements the IOrderPayment interface.
/// It follows ISP by only implementing the functionality needed for credit card payments.
/// </summary>

public class CreditCardPayment : IOrderPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Payment processed with Credit Card.");
    }
}
