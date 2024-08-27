namespace Leetcode.Easy
{
    public class IsAlphanumericStringPalindrom
    {
        // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters
        // and removing all non-alphanumeric characters, it reads the same forward and backward.
        // Alphanumeric characters include letters and numbers.
        public static bool IsPalindrome(string s)
        {
            s = s.ToUpper();
            for (int start = 0, end = s.Length - 1; start < end;)
            {
                if (!char.IsLetterOrDigit(s[start]))
                {
                    start++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[end]))
                {
                    end--;
                    continue;
                }
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
