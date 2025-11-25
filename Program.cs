using System.Diagnostics.Metrics;
using System.Numerics;

namespace WhileLoopUserNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;
            int defaultNumber = 1;

            while ( userNumber <= 100 )
            {
                Console.WriteLine("Please enter a number greater than 100: ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber <= 100)
                {
                    Console.WriteLine("The number must be greater than 100. Please try again.");
                }
            }

            Console.WriteLine($"Here are the numbers from 1 to {userNumber}:");

            while (defaultNumber <= userNumber)
            {
                Console.WriteLine(defaultNumber);
                defaultNumber++;
            }
        }
    }
}
