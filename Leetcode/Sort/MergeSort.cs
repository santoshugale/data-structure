using System;

namespace Leetcode.Sort
{
    public static class MergeSort
    {
        public static void MergeDividedArray(int[] numbers, int left, int mid, int right)
        {
            int tempIndex = 0;
            int endofLeft = mid - 1;
            int totalNumber = right - left + 1;
            int[] temp = new int[totalNumber];
            int startingPosition = left;

            while ((left <= endofLeft) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                {
                    temp[tempIndex++] = numbers[left++];
                }
                else
                {
                    temp[tempIndex++] = numbers[mid++];
                }
            }

            while (left <= endofLeft)
            {
                temp[tempIndex++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[tempIndex++] = numbers[mid++];
            }

            for (int i = 0; i < totalNumber; i++)
            {
                numbers[startingPosition++] = temp[i];
            }
        }

        static public void MergeSortRecursiveDivideAndConcur(int[] numbers, int left, int right)
        {
            if (right > left)
            {
                int mid = (right + left) / 2;

                MergeSortRecursiveDivideAndConcur(numbers, left, mid);

                MergeSortRecursiveDivideAndConcur(numbers, mid + 1, right);

                MergeDividedArray(numbers, left, mid + 1, right);
            }
        }

        static public int[] SortArrayRec(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }
            int[] leftHalf;
            int[] rightHalf;
            (leftHalf, rightHalf) = SplitArray(numbers);
            var left = SortArrayRec(leftHalf);
            var right = SortArrayRec(rightHalf);
            return MergeTwoArray(left, right);
        }

        private static int[] MergeTwoArray(int[] left, int[] right)
        {
            var mergedNumbers = new int[left.Length + right.Length];
            int leftIndex = 0;
            int rightIndex = 0;
            int mergedNumbersIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    mergedNumbers[mergedNumbersIndex++] = left[leftIndex++];
                }
                else
                {
                    mergedNumbers[mergedNumbersIndex++] = right[rightIndex++];
                }
            }

            while (leftIndex < left.Length)
            {
                mergedNumbers[mergedNumbersIndex++] = left[leftIndex++];
            }

            while (rightIndex < right.Length)
            {
                mergedNumbers[mergedNumbersIndex++] = right[rightIndex++];
            }

            return mergedNumbers;
        }

        private static (int[] left, int[] right) SplitArray(int[] numbers)
        {
            var mid = numbers.Length / 2;
            var left = new int[mid];
            var right = new int[numbers.Length - mid];
            Array.Copy(numbers, 0, left, 0, mid);
            Array.Copy(numbers, mid, right, 0, numbers.Length - mid);
            return (left, right);
        }
    }

}
