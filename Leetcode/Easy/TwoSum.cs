using System;
using System.Collections.Generic;

namespace Leetcode.Easy
{
    // Given an array of integers nums and an integer target,
    // return indices of the two numbers such that they add up to target.
    public static class TwoSum
    {
        public static int[] OptimizedSolution(int[] array, int sum)
        {
            var visitelElem = new Dictionary<int, int>
            {
                { array[0], 0 }
            };
            for (int i = 1; i <= array.Length - 1; i++)
            {
                var requiredElem = sum - array[i];
                if (visitelElem.TryGetValue(requiredElem, out var index))
                {
                    return new int[] { index, i };
                }
                else
                {
                    visitelElem.TryAdd(array[i], i);
                }
            }

            return new int[] { };
        }

        public static int[] UsingSort(int[] array, int sum)
        {
            var oArray = new int[array.Length];
            Array.Copy(array, oArray, array.Length);
            Array.Sort(array);
            int num1 = 0;
            int num2 = 0;
            var j = array.Length - 1;
            for (int i = 0; i < array.Length;)
            {
                if (array[i] + array[j] == sum)
                {
                    num1 = array[i];
                    num2 = array[j];
                    break;
                }
                if (array[i] + array[j] > sum)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            var a = Array.FindIndex(oArray, (ele) => ele == num1);
            var b = Array.FindIndex(oArray, a + 1, (ele) => ele == num2);
            return new int[] { a, b };
        }

        public static int[] BruteForce(int[] array, int sum)
        {
            for (var i = 0; i <= array.Length - 2; i++)
            {
                for (var j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { 0, 0 };
        }

        public static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var result = 0;
            foreach (var keyboard in keyboards)
            {
                foreach (var item in drives)
                {
                    var sum = keyboard + item;
                    if (sum <= b && result < sum)
                    {
                        result = sum;
                    }
                }
            }
            return result > 0 ? result : -1;
        }
    }
}
