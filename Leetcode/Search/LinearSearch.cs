using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Search
{
    public static class LinearSearch
    {
        public static int Search<T>(T[] array, T target) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (target.Equals(array[i]))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
