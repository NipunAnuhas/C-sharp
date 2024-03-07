using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number to get the fibonacci: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("first " + number + "terms of the fibonacci sereies: ");

            for (int i= 0; i < number; i++)
            {
                int result = Fibonacci(i);
                Console.WriteLine(result);

            }
            Console.ReadLine();

        }
        static int Fibonacci(int n)
        {
            if (n<= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
