namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            List<Book> books = new List<Book>
            {
            new Book("123", "hhhh", new string[] { "Ali Ali" }, new DateTime(2019, 3, 23), 49.99),
            new Book("456", "gggg", new string[] { "Ahmed Ahmed" }, new DateTime(2008, 8, 1), 39.99),
            new Book("789", "ffff", new string[] { "Alpha Gamma", "Alpha Beta", "Alpha Beta Gamma" }, new DateTime(1994, 10, 31), 59.99)
            };

            Console.WriteLine("Book Details using Book Class:");
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("Using BookFunctions:");
            foreach (Book book in books)
            {
                Console.WriteLine($"Title: {BookFunctions.GetTitle(book)}");
                Console.WriteLine($"Authors: {BookFunctions.GetAuthors(book)}");
                Console.WriteLine($"Price: {BookFunctions.GetPrice(book)}\n");
            }

            Console.WriteLine("Books using Delegates:");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            Console.WriteLine();
            LibraryEngine.ProcessBooks(books,BookFunctions.GetAuthors);
            Console.WriteLine();
            LibraryEngine.ProcessBooks(books,BookFunctions.GetTitle);
            Console.WriteLine();

            //Anonymous
            LibraryEngine.ProcessBooks(books, delegate (Book b)
            {
                return $"ISBN: {b.ISBN}";
            });

            //lambda
            LibraryEngine.ProcessBooks(books, b => $"Publication Date: {b.PublicationDate}");
            #endregion
        }
    }
}
