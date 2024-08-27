namespace Leetcode.Easy
{
    // Sam and Kelly are programming buddies.
    // Kelly resolves to practice more as Sam is ahead initially.
    // They each solve a number of problems daily.
    // Find the minimum number of days for Kelly to have solved more problems than Sam.
    // If Kelly cannot surpass return -1.
    public class CodingFriend
    {
        public static int MinDaysRequiredForKellyToSurpassSam(int samDaily, int kellyDaily, int difference)
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (i * samDaily + difference < kellyDaily * i)
                    return i;
            }
            return -1;
        }

        public static int MinDaysRequiredForKellyToSurpassSamOptimized(int samDaily, int kellyDaily, int difference)
        {
            if (samDaily > kellyDaily) return -1;
            if (samDaily == kellyDaily) return -1;

            var diff = kellyDaily - samDaily;
            return difference / diff + 1;
        }
    }
}
