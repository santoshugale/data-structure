namespace Leetcode.Easy
{
    public class FindSumOfDigitsTillSingleDigit
    {
        /// <summary>
        /// Input : 1234
        /// Output : 1
        /// Explanation : The sum of 1+2+3+4 = 10, 
        /// dig Sum == 10
        /// Hence answer will be 1+0 = 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Calculate(int n)
        {
            if (n == 0) return 0;
            return n % 9 == 0 ? 9 : n % 9;
        }
    }
}
