using Lab_Sheet_02_Q3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_02_Q3
{
    internal class TemperatureTracker
    {
        public double[] Temperature = new double[7];

        public void dailyTemperature()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter temperature for day {i + i}: ");
                Temperature[i] = double.Parse(Console.ReadLine());
            }
        }

        public void Report()
        {
            Console.WriteLine("Weekly Temerature Report:");
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Day {i + 1}: {Temperature[i]}c");
            }
        }
    }
}

    
