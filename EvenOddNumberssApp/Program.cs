using System;
using System.Collections.Generic;

namespace EvenOddNumberssApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            PrintNumbers("Even Numbers", EvenNumbers(Numbers));
            PrintNumbers("Odd Numbers", OddNumbers(Numbers));

        }
        static void PrintNumbers (string Title, IEnumerable<int> list)
        {
            Console.WriteLine(Title);
            Console.WriteLine(" [ ");
            foreach (int num in list)
            {
                Console.WriteLine($"{num} , ");
            }
            Console.WriteLine(" ] ");
        }
        static IEnumerable<int> EvenNumbers( IEnumerable<int> list)
        {
            List<int> Evens = new List<int>();
            foreach (int num in list)
            {
                if (num %2 == 0)
                    Evens.Add(num);
            }
            return Evens;
        }
        static IEnumerable<int> OddNumbers(IEnumerable<int> list)
        {
            List<int> Odds = new List<int>();
            foreach (int num in list)
            {
                if (num % 2 != 0)
                    Odds.Add(num);
            }
            return Odds;
        }
    }
}
