using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercisesHF1
{
    internal class Exercise1
    {
        internal static void AddAndMultiply()
        {
            Console.WriteLine("Enter three numbers, one at a time:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int sum = (x + y) * z;
            Console.WriteLine($"({x} + {y}) * {z} = {sum}");
        }
    }
}
