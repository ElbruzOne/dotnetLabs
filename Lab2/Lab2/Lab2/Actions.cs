using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Actions
    {
        public static void Add (List<SingleItem> target)
        {
            Console.WriteLine("Enter Author:");
            string author = Console.ReadLine();
            Console.WriteLine("Enter Book Name:");
            string bookName = Console.ReadLine();
            Console.WriteLine("Is book in Library now? (yes/no):");
            string statusString = Console.ReadLine();
            bool statusBool;
            if (statusString == "yes")
                statusBool = true;
            else statusBool = false;

            int bookId = 0;
            if (target.Count == 0)
                bookId = 1;
            else bookId = target.Count + 1;
            target.Add(new SingleItem(bookId, author, bookName, statusBool));
            Console.WriteLine($"Book {bookName} by {author} has been succefully added!");
            Console.WriteLine();

        }
    }
}
