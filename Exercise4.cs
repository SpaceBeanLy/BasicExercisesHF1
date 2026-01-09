using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercisesHF1
{
    internal class Exercise4
    {
        internal static void IsResultTheSame()
        {
            Console.WriteLine("Enter 2 numbers, one at a time.");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter one of the following arithmetic operators: +, -, *, or /.");
            char OperatorOne = Convert.ToChar(Console.ReadLine());

            double ResultOne = 0;
            switch (OperatorOne)
            {
                case '+':
                    ResultOne = a + b;
                    Console.WriteLine($"First result is {ResultOne}");
                    break;

                case '-':
                    ResultOne = a - b;
                    Console.WriteLine($"First result is {ResultOne}");
                    break;

                case '*':
                    ResultOne = a * b;
                    Console.WriteLine($"First result is {ResultOne}");
                    break;

                case '/':
                    ResultOne = a / b;
                    Console.WriteLine($"First result is {ResultOne}");
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            Console.WriteLine("Enter 2 more numbers, one at a time.");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter one of the following arithmetic operators: +, -, *, or /.");
            char OperatorTwo = Convert.ToChar(Console.ReadLine());

            double ResultTwo = 0;
            switch (OperatorTwo)
            {
                case '+':
                    ResultTwo = c + d;
                    Console.WriteLine($"First result is {ResultTwo}");
                    break;

                case '-':
                    ResultTwo = c - d;
                    Console.WriteLine($"First result is {ResultTwo}");
                    break;

                case '*':
                    ResultTwo = c * d;
                    Console.WriteLine($"First result is {ResultTwo}");
                    break;

                case '/':
                    ResultTwo = c / d;
                    Console.WriteLine($"First result is {ResultTwo}");
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            if (ResultOne == ResultTwo)
            {
                Console.WriteLine("Results are the same!");
            }
            else 
            {
                Console.WriteLine("Results are not the same.");
            }
        }
    }
}
