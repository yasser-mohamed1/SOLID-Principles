
/// <summary>
/// The Book class is responsible for representing the details of a book.
/// It has a single responsibility: to store and manage the information about a book such as its title, author, and price.
/// </summary>

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public override string ToString()
    {
        return $"Book Title: {Title} - Author: {Author} - Price: {Price:C}";
    }
}
