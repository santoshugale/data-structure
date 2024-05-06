namespace Leetcode.Sort
{
    public static class QuickSort
    {
        /// function that consider last element as pivot,  
        /// place the pivot at its exact position, and place  
        /// smaller elements to left of pivot and greater  
        /// elements to right of pivot
        private static int Partition(int[] numbers, int start, int end)
        {
            int pivot = numbers[end];
            int i = start - 1;

            for (int index = start; index <= end - 1; index++)
            {
                // If current element is smaller than the pivot  
                if (numbers[index] < pivot)
                {
                    i++; // increment index of smaller element  
                    int temp = numbers[i];
                    numbers[i] = numbers[index];
                    numbers[index] = temp;
                }
            }
            int temp1 = numbers[i + 1];
            numbers[i + 1] = numbers[end];
            numbers[end] = temp1;
            return i + 1;
        }

        public static void Sort(int[] numbers)
        {

            SortRec(numbers, 0, numbers.Length - 1);
        }

        public static void SortRec(int[] numbers, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(numbers, start, end);
                SortRec(numbers, start, pivot - 1);
                SortRec(numbers, pivot + 1, end);
            }
        }
    }
}
