
/// <summary>
/// The BookWithDiscount class is a subclass of the Book class.
/// It demonstrates the Liskov Substitution Principle by extending the Book class
/// without affecting the correctness or functionality of the program,
/// ensuring that BookWithDiscount can be used anywhere the Book class is expected.
/// </summary>

public class BookWithDiscount : Book
{
    private readonly Discount _discount;

    public BookWithDiscount(string title, string author, decimal price, Discount discount)
        : base(title, author, price)
    {
        _discount = discount;
    }

    public decimal GetDiscountedPrice()
    {
        return _discount.ApplyDiscount(Price);
    }
}
