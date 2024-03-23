using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_02_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();

            tracker.dailyTemperature();
            Console.WriteLine("\n");
            tracker.Report();

            Console.ReadLine();
        }
    }
}
