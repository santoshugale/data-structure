using Leetcode.Recursion;
using Xunit;

namespace LeetcodeTest.Recursion
{
    public class FibonacciTest
    {
        private readonly Fibonacci _fibonacci;
        public FibonacciTest()
        {
            _fibonacci = new Fibonacci();
        }

        [Fact]
        public void Test_For_1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            _fibonacci.PrintFibonnaciSequential(1);
            Assert.Equal("0 ", sw.ToString());
        }

        [Fact]
        public void Test_For_2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            _fibonacci.PrintFibonnaciSequential(2);
            Assert.Equal("0 1 ", sw.ToString());
        }

        [Fact]
        public void Test_For_3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            _fibonacci.PrintFibonnaciSequential(3);
            Assert.Equal("0 1 1 ", sw.ToString());
        }

        [Fact]
        public void Test_NthFib_1()
        {
            var a = _fibonacci.GetNthFibonacciRecursive(3);
            var b = _fibonacci.GetNthFibRecursiveWithMemoization(4);
            Assert.Equal(2, a);
            Assert.Equal(3, b);
        }

        [Fact]
        public void Test_NthFib_4()
        {
            var a = _fibonacci.GetNthFibonacciRecursive(5);
            var b = _fibonacci.GetNthFibRecursiveWithMemoization(6);
            Assert.Equal(5, a);
            Assert.Equal(8, b);
        }
    }
}
