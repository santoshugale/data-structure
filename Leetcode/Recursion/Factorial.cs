using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Recursion
{
    public class Factorial
    {
        public static int GetFactorialNonRecursive(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static int GetFactorialRecursive(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * GetFactorialNonRecursive(number - 1);
            }
        }
    }
}
