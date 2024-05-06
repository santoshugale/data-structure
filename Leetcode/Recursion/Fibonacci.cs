using System;

namespace Leetcode.Recursion
{
    public class Fibonacci
    {
        public static int GetNthFibonacciRecursive(int number)
        {
            return Recursive(number);
        }

        private static int Recursive(int number)
        {
            // Condition which breaks the recursion
            if (number <= 1)
            {
                return number;
            }
            else
            {
                return GetNthFibonacciRecursive(number - 1) + GetNthFibonacciRecursive(number - 2);
            }
        }

        public static void PrintFibonnaciSequential(int len)
        {
            if (len < 1)
            {
                return;
            }
            int first = 0;
            int second = 1;
            Console.Write($"{first} ");
            for (int i = 1; i < len; i++)
            {
                Console.Write($"{second} ");
                var next = first + second;
                first = second;
                second = next;
            }
        }
    }
}