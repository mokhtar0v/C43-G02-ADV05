using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LibraryEngine
    {
        public delegate string BookDelegate(Book B);
        public static void ProcessBooks(List<Book> BookList, BookDelegate ptr)
        {
            foreach (Book B in BookList)
            {
                Console.WriteLine(ptr(B));
            }
        }
    }
}
