using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Leetcode
{
    public static class FourSum
    {
        public static List<List<int>> OptimizedSolution(List<int> numbers)
        {
            var result = new List<List<int>>();
            return result;
        }

        public static List<List<int>> BruteForce(List<int> num, int sum)
        {
            var comparer = new SequentialComparer<List<int>>();
            var result = new HashSet<List<int>>();
            var dict = new Dictionary<int, Pair>();

            for (var i = 0; i <= num.Count - 2; i++)
            {
                for (var j = i + 1; j <= num.Count - 1; j++)
                {
                    var currentSum = num[i] + num[j];
                    if (!dict.ContainsKey(currentSum))
                    {
                        dict.Add(currentSum, new Pair { Index1 = i, Index2 = j });
                    }
                }
            }


            for (var i = 0; i <= num.Count - 2; i++)
            {
                for (var j = i + 1; j <= num.Count - 1; j++)
                {
                    var currentSum = num[i] + num[j];
                    if (!dict.ContainsKey(sum - currentSum)) continue;
                    var pair = dict[sum - currentSum];
                    if (pair.Index1 != i
                        && pair.Index1 != j
                        && pair.Index2 != i
                        && pair.Index2 != j)

                    {
                        var a = new List<int> { num[i], num[j], num[pair.Index1], num[pair.Index2] };
                        a.Sort();
                        if (!result.Contains(a, comparer))
                        {
                            result.Add(a);
                        }

                    }
                }
            }

            return result.ToList();
        }

        public class Pair
        {
            public int Index1 { get; set; }
            public int Index2 { get; set; }
        }
        public class SequentialComparer<TSource> : IEqualityComparer<TSource> where TSource : IEnumerable<int>
        {
            public bool Equals(TSource x, TSource y)
            {
                return x.SequenceEqual(y);
            }

            public int GetHashCode(TSource obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
