
/// <summary>
/// The Discount abstract class is open for extension and closed for modification.
/// You can extend this class by creating new types of discounts, but you should not modify the existing functionality.
/// </summary>

public abstract class Discount
{
    public abstract decimal ApplyDiscount(decimal price);
}
