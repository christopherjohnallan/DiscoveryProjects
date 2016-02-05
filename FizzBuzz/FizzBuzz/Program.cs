using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "Write a program that prints the numbers from 1 to 100.
// But for multiples of three print “Fizz” instead of the number
// For the multiples of five print “Buzz”
// For numbers which are multiples of both three and five print “FizzBuzz”."

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                bool multipleOfThree = MultipleOf(i, 3);
                bool multipleOfFive = MultipleOf(i, 5);

                if (multipleOfThree && multipleOfFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (multipleOfThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (multipleOfFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool MultipleOf(int i, int divideBy)
        {
            return i % divideBy == 0;
        }
    }
}
