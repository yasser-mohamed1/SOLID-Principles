
/// <summary>
/// The NoDiscount class extends the Discount class and applies no discount to the book price.
/// </summary>

public class NoDiscount : Discount
{
    public override decimal ApplyDiscount(decimal price)
    {
        return price;
    }
}
