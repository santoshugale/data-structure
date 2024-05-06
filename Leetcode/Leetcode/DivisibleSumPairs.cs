using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace Leetcode
{
    public class DivisibleSumPairs
    {
        public static int pageCount(int n, int p)
        {
            return p / 2 > (n - p) / 2 ? (n - p) / 2 : p / 2;
        }
    }
}
