using System;
using System.Collections.Generic;

namespace Leetcode.Recursion
{
    public class Fibonacci
    {
        public Dictionary<int, int> fibData;

        public Fibonacci()
        {
            fibData = new Dictionary<int, int>();
        }
        public int GetNthFibonacciRecursive(int number)
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

        public int GetNthFibRecursiveWithMemoization(int number)
        {
            // Condition which breaks the recursion
            if (number <= 1)
            {
                return number;
            }
            else
            {
                if (fibData.TryGetValue(number, out int value))
                {
                    return value;
                }
                else
                {
                    var result = GetNthFibonacciRecursive(number - 1) + GetNthFibonacciRecursive(number - 2);
                    fibData.Add(number, result);
                    return result;
                }
            }
        }

        public void PrintFibonnaciSequential(int len)
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
