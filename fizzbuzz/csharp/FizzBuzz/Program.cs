using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <=100; n++)
            {
                if (n % 15 == 0) // if n is evenly divisible by 15, run code block below:
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (n % 3 == 0) // if n is evenly divisible by 3, run code block below:
                {
                    Console.WriteLine("fizz");
                }
                else if (n % 5 == 0) // if n is evenly divisible by 5, run code block below:
                {
                    Console.WriteLine("buzz");
                }
                else // else, print out "n" to the console:
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
