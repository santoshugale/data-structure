using System;

namespace Leetcode.Leetcode.Easy
{
    public class FindTheIndexOfTheFirstOccurrenceInString
    {
        // Find the Index of the First Occurrence in a String
        public static int StrStr(string haystack, string needle)
        {
            for (var i = 0; i < haystack.Length; i++)
            {
                for (var j = 0; j < needle.Length && i+j < haystack.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                    
                }
            }
            return -1;
        }
    }
}
