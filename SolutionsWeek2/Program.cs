using MyClassLib;
using System;

namespace SolutionsWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oefening 1
            int getal = 2;
            if (getal.IsOdd())
            {
                Console.WriteLine("Number is even");
            } else
            {
                Console.WriteLine("Number is not even");
            }

            // Oefening 2
            string toCheck = "Hello world hehe";
            char letterToCheck = 'h';
            Console.WriteLine($"'{toCheck}' : found '{letterToCheck}' {toCheck.CountChar(letterToCheck)} time(s).");
        }
    }
}
