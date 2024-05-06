using Leetcode.Easy;
using Xunit;

namespace LeetCodeUnitTest.Easy
{
    public class PalindromeNumberTest
    {
        [Fact]
        public void IsPalindromeBruteForceTest1()
        {
            Assert.True(PalindromeNumber.IsPalindromeBruteForce(12321));
        }

        [Fact]
        public void IsPalindromeBruteForceTest2()
        {
            Assert.True(PalindromeNumber.IsPalindromeBruteForce(1));
        }

        [Fact]
        public void IsPalindromeBruteForceTest3()
        {
            Assert.False(PalindromeNumber.IsPalindromeBruteForce(1233));
        }

        [Fact]
        public void IsPalindromeOptimizedTest1()
        {
            Assert.True(PalindromeNumber.IsPalindromeOptimized(12321));
        }

        [Fact]
        public void IsPalindromeOptimizedTest2()
        {
            Assert.True(PalindromeNumber.IsPalindromeOptimized(1));
        }

        [Fact]
        public void IsPalindromeOptimizedTest3()
        {
            Assert.False(PalindromeNumber.IsPalindromeOptimized(1233));
        }
    }
}
