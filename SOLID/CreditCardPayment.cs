
/// <summary>
/// The CreditCardPayment class implements the IOrderPayment interface.
/// It follows ISP by only implementing the functionality needed for credit card payments.
/// </summary>

public class CreditCardPayment : IOrderPayment
{
    private readonly decimal _totalAmount;

    public CreditCardPayment(decimal totalAmount)
    {
        _totalAmount = totalAmount;
    }

    public void ProcessPayment()
    {
        Console.WriteLine($"Payment of {_totalAmount:C} processed with Credit Card.");
    }
}