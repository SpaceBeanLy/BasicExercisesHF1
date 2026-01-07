using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercisesHF1
{
    internal class Exercise6
    {
        internal static void TheCubeOf()
        {
            Console.WriteLine("Enter a number:");
            double number = Convert.ToDouble(Console.ReadLine());
            double cube = (number * number * number);
            Console.WriteLine($"{number} cubed is {cube}.");
        }
    }
}
