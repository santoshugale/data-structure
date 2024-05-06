using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class AllBinaryStringsOfNBits
    {
        public static void PrintTheArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        // Function to generate all binary strings
        public static void GenerateAllBinaryStrings(int n, int[] arr, int i=0)
        {
            if (i == n)
            {
                PrintTheArray(arr);
                return;
            }

            // First assign "0" at ith position
            // and try for all other permutations
            // for remaining positions
            arr[i] = 0;
            GenerateAllBinaryStrings(n, arr, i + 1);

            // And then assign "1" at ith position
            // and try for all other permutations
            // for remaining positions
            arr[i] = 1;
            GenerateAllBinaryStrings(n, arr, i + 1);
        }

        public static void GenerateAllBinaryStrings(int n, int[] arr)
        {
            if (n < 1)
            {
                PrintTheArray(arr);
                return;
            }

            // First assign "0" at n-1 position
            // and try for all other permutations
            // for remaining positions
            arr[n - 1] = 0;
            GenerateAllBinaryStrings(n - 1, arr);

            // And then assign "1" at n-1 position
            // and try for all other permutations
            // for remaining positions
            arr[n - 1] = 1;
            GenerateAllBinaryStrings(n - 1, arr);
        }


        //// Driver Code
        //public static void Main(String[] args)
        //{
        //    int n = 4;
        //    int[] arr = new int[n];
        //    GenerateAllBinaryStrings(n, arr,0);
        //}
    }
}
