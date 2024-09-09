namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("C# Programming", "Jon Skeet", 50);
            Book book2 = new BookWithDiscount("Design Patterns", "Gaurav Arora", 60, new SeasonalDiscount(10));
            Console.WriteLine($"Discounted price for {book2.Title} book: {((BookWithDiscount)book2).GetDiscountedPrice():C}");
            Order order = new Order();
            order.AddBook(book1);
            order.AddBook(book2);

            IOrderNotification notification = new EmailNotification(order.Books);
            IOrderPayment payment = new CreditCardPayment(order.TotalAmount);

            OrderProcessor processor = new OrderProcessor(notification, payment);
            processor.ProcessOrder();
        }
    }

}
