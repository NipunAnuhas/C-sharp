using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_02_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            books book = new books();
            book.Author = "Anita Desai";
            book.Title = "Village by the sea";

            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);

            Console.ReadLine();
        }
    }
}
