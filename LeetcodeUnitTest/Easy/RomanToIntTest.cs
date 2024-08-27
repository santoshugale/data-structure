using Leetcode.Easy;
using Xunit;

namespace LeetcodeUnitTest.Easy
{
    public class RomanToIntTest
    {
        [Fact]
        public void RomanToIntTestCase1()
        {
            var result = RomantoInteger.RomanToIntBruteForce("XXVII");
            Assert.Equal(27, result);
        }

        [Fact]
        public void RomanToIntTestCase2()
        {
            var result = RomantoInteger.RomanToIntBruteForce("III");
            Assert.Equal(3, result);
        }

        [Fact]
        public void RomanToIntTestCase3()
        {
            var result = RomantoInteger.RomanToIntBruteForce("MCMXCIV");
            Assert.Equal(1994, result);
        }

        [Fact]
        public void RomanToIntTestCase4()
        {
            var result = RomantoInteger.RomanToIntBruteForce("LVIII");
            Assert.Equal(58, result);
        }

        [Fact]
        public void RomanToIntTestCase5()
        {
            var result = RomantoInteger.RomanToIntBruteForce("MMMDCCXXIV");
            Assert.Equal(3724, result);
        }

        [Fact]
        public void RomanToIntOptimizedTestCase1()
        {
            var result = RomantoInteger.RomanToIntOptimized("XXVII");
            Assert.Equal(27, result);
        }

        [Fact]
        public void RomanToIntOptimizedTestCase2()
        {
            var result = RomantoInteger.RomanToIntOptimized("III");
            Assert.Equal(3, result);
        }

        [Fact]
        public void RomanToIntOptimizedTestCase3()
        {
            var result = RomantoInteger.RomanToIntOptimized("MCMXCIV");
            Assert.Equal(1994, result);
        }

        [Fact]
        public void RomanToIntOptimizedTestCase4()
        {
            var result = RomantoInteger.RomanToIntOptimized("LVIII");
            Assert.Equal(58, result);
        }

        [Fact]
        public void RomanToIntOptimizedTestCase5()
        {
            var result = RomantoInteger.RomanToIntOptimized("MMMDCCXXIV");
            Assert.Equal(3724, result);
        }
    }
}
