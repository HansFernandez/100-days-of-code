using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K. Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Green Eggs and Ham";
            book2.author = "Dr. Seuss";
            book2.pages = 21;

            Console.WriteLine(book1.title, book1.author);

            Console.ReadLine();
        }
    }
}
