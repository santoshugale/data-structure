using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Easy
{
    public class PalindromeNumber
    {
        public static bool IsPalindromeBruteForce(int x)
        {
            var array = x.ToString().ToCharArray();
            var end = array.Length - 1;
            for (int i = 0; i < end; i++, end--)
            {
                if (array[i] != array[end])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindromeOptimized(int x)
        {
            // When x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            var reverseNumber = 0;

            while (x > reverseNumber)
            {
                var lastDigit = x % 10;
                reverseNumber = (reverseNumber * 10) + lastDigit;
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return reverseNumber == x || x == reverseNumber / 10;
        }
    }
}
