
/// <summary>
/// The Order class is responsible for managing a customer's order.
/// It has a single responsibility: to store books in an order and calculate the total amount for that order.
/// </summary>

public class Order
{
    public List<Book> Books { get; set; } = [];
    /// <summary>
    /// The total amount for the order, including any discounts on books if applicable.
    /// </summary>
    public decimal TotalAmount
    {
        get
        {
            return Books.Sum(book =>
            {
                if (book is BookWithDiscount discountedBook)
                {
                    return discountedBook.GetDiscountedPrice();
                }
                return book.Price;
            });
        }
    }
    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }
}
