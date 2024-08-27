using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Easy
{
    public class ReverseString
    {
        public static string ReverseWithExtraSpace(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            var result = new char[text.Length];
            var index = text.Length - 1;
            foreach (char c in text)
            {
                result[index--] = c;
            }
            return new string(result);
        }

        public static string ReverseWithoutExtraSpace(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            var result = text.ToCharArray();
            for (int index = 0; index <= result.Length / 2 - 1; index++)
            {
                var temp = result[index];
                result[index] = result[result.Length - 1 - index];
                result[result.Length - 1 - index] = temp;
            }
            return new string(result);
        }
    }
}
