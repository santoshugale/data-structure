using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Sort
{
    public class InsertionSort
    {
        /// <summary>
        /// The array is virtually split into a sorted and an unsorted part. 
        /// Values from the unsorted part are picked and placed at the correct position in the sorted part.
        /// </summary>
        /// <param name="numbers"></param>
        public static void Sort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                var key = numbers[i];
                int j = i-1;
                // insert key in sorted array of 0 to i-1 i.e 0-j;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
        }
    }
}
