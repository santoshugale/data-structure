using System;

namespace Leetcode.Search
{
    public static class BinarySearch
    {
        public static int BinarySearchRecursive_ReturnIndex(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return BinarySearchRecursive_ReturnIndex(arr, left, mid - 1, x);

                return BinarySearchRecursive_ReturnIndex(arr, mid + 1, right, x);
            }
            return -1;
        }

        public static bool SearchRecursive<T>(T[] array, T target) where T : IComparable, IEquatable<T>
        {
            if (array.Length == 0)
            {
                return false;
            }
            else
            {
                var mid = array.Length / 2;
                if (array[mid].Equals(target))
                {
                    return true;
                }
                else
                {
                    if (target.CompareTo(array[mid]) > 0)
                    {
                        var newArray = new T[(array.Length - mid) - 1];
                        Array.Copy(array, mid + 1, newArray, 0, (array.Length - mid) - 1);
                        return SearchRecursive(newArray, target);
                    }
                    else
                    {
                        var newArray = new T[mid];
                        Array.Copy(array, 0, newArray, 0, mid);
                        return SearchRecursive(newArray, target);
                    }
                }
            }
        }

        public static int Search1<T>(T[] array, T target) where T : IComparable, IEquatable<T>
        {
            var first = 0;
            var last = array.Length - 1;

            while (first <= last)
            {
                var midIndex = (first + last) / 2;
                if (array[midIndex].Equals(target))
                {
                    return midIndex;
                }
                if (target.CompareTo(array[midIndex]) > 0)
                {
                    first = midIndex + 1;
                }
                else
                {
                    last = midIndex - 1;
                }
            }
            return -1;
        }
    }
}
