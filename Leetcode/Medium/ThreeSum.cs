using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Medium
{
    public static class ThreeSum
    {
        public static List<List<int>> OptimizedSolution(List<int> numbers)
        {
            var result = new List<List<int>>();
            numbers.Sort();
            for (var firstIndex = 0; firstIndex <= numbers.Count - 2; firstIndex++)
            {
                if (firstIndex > 0 && numbers[firstIndex] == numbers[firstIndex - 1])
                {
                    continue;
                }

                var secondIndex = firstIndex + 1;
                var thirdIndex = numbers.Count - 1;

                while (secondIndex < thirdIndex)
                {
                    var sum = numbers[firstIndex] + numbers[secondIndex] + numbers[thirdIndex];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { numbers[firstIndex], numbers[secondIndex], numbers[thirdIndex] });
                        thirdIndex--;
                        while (secondIndex < thirdIndex && numbers[thirdIndex] == numbers[thirdIndex + 1])
                        {
                            thirdIndex--;
                        };
                    }
                    else if (sum < 0)
                    {
                        secondIndex++;
                    }
                    else
                    {
                        thirdIndex--;
                    }
                }
            }

            return result;
        }

        public static List<List<int>> BruteForce(List<int> numbers)
        {
            var comparer = new SequentialComparer<List<int>>();
            var result = new HashSet<List<int>>();
            for (var i = 0; i <= numbers.Count - 3; i++)
            {
                for (var j = i + 1; j <= numbers.Count - 2; j++)
                {
                    for (var k = j + 1; k <= numbers.Count - 1; k++)
                    {
                        if (numbers[i] + numbers[j] + numbers[k] == 0)
                        {
                            var triplet = new List<int> { numbers[i], numbers[j], numbers[k] };
                            triplet.Sort();
                            if (!result.Contains(triplet, comparer)) result.Add(triplet);
                        }
                    }
                }
            }

            return result.ToList();
        }

        public class SequentialComparer<TSource> : IEqualityComparer<TSource> where TSource : IEnumerable<int>
        {
            public bool Equals(TSource x, TSource y)
            {
                return y != null && x != null && x.SequenceEqual(y);
            }

            public int GetHashCode(TSource obj)
            {
                return obj.GetHashCode();
            }
        }
    }
}
