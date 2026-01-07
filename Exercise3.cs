using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercisesHF1
{
    internal class Exercise3
    {
        internal static void ElementaryOperations()
        {
            Console.WriteLine("Please type two numbers, one at a time.");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            if (a == 0 || b == 0)
                Console.WriteLine("Cannot divide by zero.");
            else
                Console.WriteLine($"{a} / {b} = {a / b}");
        }

    }
}
