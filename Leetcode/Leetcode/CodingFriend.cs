using System;
using System.Collections.Generic;

namespace Leetcode.Leetcode
{
    public class CodingFriend
    {
        public static int minNum(int samDaily, int kellyDaily, int difference)
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                if ((i * samDaily) + difference < kellyDaily * i)
                    return i;
            }
            return -1;
        }

        public static int minNumOptimized(int samDaily, int kellyDaily, int difference)
        {
            if (samDaily > kellyDaily) return -1;
            if (samDaily == kellyDaily) return -1;

            var diff = kellyDaily - samDaily;
            return (difference / diff) + 1;
        }
    }
}
