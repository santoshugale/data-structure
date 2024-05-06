using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Easy
{
    public class RomantoInteger
    {
        public static Dictionary<char, int> symbols = new Dictionary<char, int>(){
        { 'I', 1},
        { 'V', 5},
        { 'X', 10},
        { 'L', 50},
        { 'C', 100},
        { 'D', 500},
        { 'M', 1000}};

        public static int RomanToIntBruteForce(string s)
        {
            var result = 0;
            for (var i = 0; i <= s.Length - 1; i++)
            {
                if (i + 1 <= s.Length - 1)
                {
                    if (s[i] == 'I')
                    {
                        if (s[i + 1] == 'V')
                        {
                            result += 4;
                            i++;
                        }
                        else if (s[i + 1] == 'X')
                        {
                            result += 9;
                            i++;
                        }
                        else
                        {
                            result += 1;
                        }
                    }
                    else if (s[i] == 'X')
                    {
                        if (s[i + 1] == 'L')
                        {
                            result += 40;
                            i++;
                        }
                        else if (s[i + 1] == 'C')
                        {
                            result += 90;
                            i++;
                        }
                        else
                        {
                            result += 10;
                        }
                    }
                    else if (s[i] == 'C')
                    {
                        if (s[i + 1] == 'D')
                        {
                            result += 400;
                            i++;
                        }
                        else if (s[i + 1] == 'M')
                        {
                            result += 900;
                            i++;
                        }
                        else
                        {
                            result += 100;
                        }
                    }
                    else
                    {
                        result += symbols[s[i]];
                    }
                }
                else
                {
                    result += symbols[s[i]];
                }
            }
            return result;
        }

        public static int RomanToIntOptimized(string s)
        {
            var result = 0;
            for (var i = 0; i <= s.Length - 1; i++)
            {
                if (i <= s.Length - 2 && symbols[s[i]] < symbols[s[i + 1]])
                {
                    result -= symbols[s[i]];
                }
                else
                {
                    result += symbols[s[i]];
                }
            }
            return result;
        }
    }
}
