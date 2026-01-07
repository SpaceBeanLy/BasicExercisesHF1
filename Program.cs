namespace BasicExercisesHF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my first assignment for HF1!");
            
            Console.WriteLine("Exercise 1:");
            Exercise1.AddAndMultiply();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            Console.WriteLine("Exercise 2:");
            Exercise2.CelciusToFahrenheit();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            Console.WriteLine("Exercise 3:");
            Exercise3.ElementaryOperations();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            Console.WriteLine("Exercise 4:");
            Exercise4.IsResultTheSame();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            Console.WriteLine("Exercise 5:");
            Exercise5.ModuloOperations();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            Console.WriteLine("Exercise 6:");
            Exercise6.TheCubeOf();
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();

            Console.WriteLine("Exercise 7:");
            Exercise7.SwapTwoNumbers();
            Console.WriteLine("Thank you for going through these exercises with me!");

        }
    }
}
