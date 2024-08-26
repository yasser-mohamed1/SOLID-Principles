
/// <summary>
/// The SeasonalDiscount class extends the Discount class and provides a specific implementation for applying a percentage-based discount.
/// </summary>

public class SeasonalDiscount : Discount
{
    private readonly decimal _percentage;

    public SeasonalDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public override decimal ApplyDiscount(decimal price)
    {
        return price - (price * _percentage / 100);
    }
}
