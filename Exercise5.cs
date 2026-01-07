using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercisesHF1
{
    internal class Exercise5
    {
        internal static void ModuloOperations()
        {
            Console.WriteLine("Enter three numbers, one at a time:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int modSum1 = (x % y);
            int modSum2 = (modSum1 % z);
            Console.WriteLine($"Result is {modSum2}.");
        }
    }
}
