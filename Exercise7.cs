using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercisesHF1
{
    internal class Exercise7
    {
        internal static void SwapTwoNumbers()
        {
            Console.WriteLine("Please write two numbers, one at a time.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before: a = {a}, b = {b}.");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After: a = {a}, b = {b}.");
        }
    }
}
