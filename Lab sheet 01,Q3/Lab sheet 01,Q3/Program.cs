using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet_01_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;

            Console.Write("Enter a positive number: ");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for(int i = 1; i <= number; i++)
                {
                    sum = sum + i;
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
