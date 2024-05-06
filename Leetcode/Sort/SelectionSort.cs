using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Sort
{
    public class SelectionSort
    {
        /// <summary>
        /// sorts an array by repeatedly finding the minimum element (considering ascending order)
        /// from unsorted part and putting it at the beginning.
        /// </summary>
        /// <param name="numbers"></param>
        public static void Sort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                var min_index = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[min_index] > numbers[j])
                    {
                        min_index = j;
                    }
                }
                var temp = numbers[min_index];
                numbers[min_index] = numbers[i];
                numbers[i] = temp;
            }
        }
    }
}
