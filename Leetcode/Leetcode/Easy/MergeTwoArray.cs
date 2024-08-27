using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Leetcode.Easy
{
    public class MergeTwoArray
    {
        public static int[] Merge(int[] array1, int[] array2)
        {
            if (array1.Length == 0)
            {
                return array2;
            }
            if (array2.Length == 0)
            {
                return array1;
            }

            int array1Index = 0;
            int array2Index = 0;
            int resultIndex = 0;
            var result = new int[array1.Length + array2.Length];
            while (array1Index < array1.Length && array2Index < array2.Length)
            {
                if (array1[array1Index] < array2[array2Index])
                {
                    result[resultIndex++] = array1[array1Index++];
                }
                else
                {
                    result[resultIndex++] = array2[array2Index++];
                }
            }
            while (array1Index < array1.Length)
            {
                result[resultIndex++] = array1[array1Index++];
            }
            while (array2Index < array2.Length)
            {
                result[resultIndex++] = array2[array2Index++];
            }
            return result;
        }
    }
}
