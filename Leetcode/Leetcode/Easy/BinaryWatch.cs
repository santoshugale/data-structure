using System.Collections.Generic;

namespace Leetcode.Leetcode.Easy
{
    public class BinaryWatch
    {
        public static List<string> ReadBinaryWatchTwoForLoops(int turnedOn)
        {
            var result = new List<string>();

            // Iterate through all possible hours and minutes
            for (int hour = 0; hour < 12; hour++)
            {
                for (int minute = 0; minute < 60; minute++)
                {
                    // Count the number of set bits in the binary representation of hour and minute
                    if (CountOneBits(hour) + CountOneBits(minute) == turnedOn)
                    {
                        // Format the time and add it to the result list
                        result.Add($"{hour}:{minute:D2}");
                    }
                }
            }

            return result;
        }

        // Count the number of set bits using bitwise operations
        private static int CountOneBits(int num)
        {
            int count = 0;

            while (num > 0)
            {
                count += num & 1;
                num >>= 1;
            }

            return count;
        }
    }
}
