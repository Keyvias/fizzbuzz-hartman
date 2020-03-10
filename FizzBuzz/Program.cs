using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            FizzBuzz(number);
            Console.ReadKey();
        }
        /*
         * This program will recieve int X and print all numbers from 1-x 
         * (if x is 3 it would say:
         * 1
         * 2
         * 3)
         * 
         * Here's the catch: \
         * Numbers that are divisible by 3 will be replaced with Fizz
         * Numbers that are divisible by 5 will be replaced with Buzz
         * Numbers that are divisible by both will be replaced with FizzBuzz
         * 
         */
        static void FizzBuzz(int x)
        {
            string Buzz = "Buzz";
            string Fizz = "Fizz";
            string FizzBuzz = "Fizzbuzz";
            string BuzzAnswer = "";
            string FizzAnswer = "";
            string FizzBuzzAnswer = "";


            for (int y = 1; y <= x; y++)
                if (y % 3 == 0 && y % 5 == 0)
                {
                    FizzBuzzAnswer += FizzBuzz;

                    Console.WriteLine(FizzBuzzAnswer);
                }
                else if (y % 3 == 0)
                {
                    FizzAnswer += Fizz;
                    FizzBuzzAnswer += Fizz;
                    Console.WriteLine(FizzAnswer);
                }
                else if (y % 5 == 0)
                { 
                    BuzzAnswer += Buzz;
                    FizzBuzzAnswer += Buzz;
       
                    Console.WriteLine(BuzzAnswer);
                }

                else
                {
                    Console.WriteLine(y);
                }
        }
    }
}
