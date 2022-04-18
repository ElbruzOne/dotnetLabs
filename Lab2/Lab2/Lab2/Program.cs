using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SingleItem> library = new List<SingleItem>();

            Console.WriteLine("What do you want to do? 1 - Add Book, 2 - Show all books, 3 - Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice == 1 || choice == 2)
            {
                switch (choice)
                {
                    case 1:
                        Actions.Add(library);
                        Console.WriteLine("What do you want to do? 1 - Add Book, 2 - Show all books, 3 - Exit");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        if (library.Count == 0)
                            Console.WriteLine("Library is empty");
                        else
                            foreach (SingleItem kek in library)
                            {
                                Console.WriteLine($"Item ID: {kek.itemID}, Author: {kek.itemAuthor}, Book: {kek.itemName}, Status: {kek.itemStatus}");
                            }
                        Console.WriteLine("What do you want to do? 1 - Add Book, 2 - Show all books, 3 - Exit");
                        choice = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
