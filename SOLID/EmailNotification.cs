
/// <summary>
/// The EmailNotification class implements the IOrderNotification interface.
/// It follows ISP by only implementing the functionality needed for sending email notifications.
/// </summary>

public class EmailNotification : IOrderNotification
{
    private readonly List<Book> _books;

    public EmailNotification(List<Book> books)
    {
        _books = books;
    }

    public void SendOrderConfirmation()
    {
        Console.WriteLine("Order confirmation from Book Store.");
        foreach (var book in _books)
        {
            Console.WriteLine(book.ToString());
        }
    }
}
