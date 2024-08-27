using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Easy
{
    public static class StringProblems
    {
        public static void FindOccurancesOfChars(string value)
        {
            var map = new Dictionary<char, int>();
            foreach (char character in value)
            {
                if (map.ContainsKey(character))
                {
                    map[character]++;
                }
                else
                {
                    map[character] = 1;
                }
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public static void RemoveDuplicateFromString(string value)
        {
            var uniqueChars = new HashSet<char>(value);
            uniqueChars.ToList().ForEach((item) => Console.Write(item));
        }

        public static string ReverseCharactersInString(string input)
        {
            var inputArray = input.ToCharArray();
            for (int i = 0; i < input.Length / 2; i++)
            {
                var tmp = input[i];
                inputArray[i] = inputArray[inputArray.Length - 1 - i];
                inputArray[inputArray.Length - 1 - i] = tmp;
            }
            return new string(inputArray);
        }

        public static string ReverseCharactersInStringRecursive(string input)
        {
            if (input.Length == 0)
            {
                return input;
            }
            return ReverseCharactersInStringRecursive(input.Substring(1)) + input[0];
        }

        public static IEnumerable<char> FindCommonLongPrefix(string[] input)
        {
            var prefix = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                prefix = CommonPrefixBetweenTwoString(prefix, input[i]);
            }
            return prefix;
        }

        public static string CommonPrefixBetweenTwoString(string first, string second)
        {
            var prefix = new StringBuilder();
            for (int i = 0, j = 0; i < first.Length && j < second.Length; i++, j++)
            {
                if (first[i] != second[i])
                {
                    break;
                }
                else
                {
                    prefix.Append(first[i]);
                }
            }
            return prefix.ToString();
        }

        public static string ReverseWorkdsInString(string input)
        {
            var words = input.Split(' ');
            for (int i = 0; i < words.Length / 2; i++)
            {
                var tmp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = tmp;
            }
            return string.Join(' ', words);
        }
    }
}
