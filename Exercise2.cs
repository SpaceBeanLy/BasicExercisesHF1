using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercisesHF1
{
    internal class Exercise2
    {
        internal static void CelciusToFahrenheit()
        {
            Console.WriteLine("Write a temperature in degrees Celsius:");
            double c;
            while (true)
            {
                string input = Console.ReadLine();
                if (!double.TryParse(input, out c))
                {
                    Console.WriteLine("Invalid input. Try again:");
                    continue;
                }
                if (c < -271.15)
                {
                    Console.WriteLine("Temperature below absolute zero. Try again:");
                    continue;
                }
                break;
            }
            double f = c * 1.8 + 32;
            Console.WriteLine($"{c} degrees Celsius is {f} degrees Fahrenheit.");
        }
    }
}
