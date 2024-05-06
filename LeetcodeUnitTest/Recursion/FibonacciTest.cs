using Leetcode.Recursion;
using Xunit;

namespace LeetcodeTest.Recursion
{
    public class FibonacciTest
    {
        [Fact]
        public void Test_For_1()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Fibonacci.PrintFibonnaciSequential(1);
            Assert.Equal("0 ", sw.ToString());
        }

        [Fact]
        public void Test_For_2()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Fibonacci.PrintFibonnaciSequential(2);
            Assert.Equal("0 1 ", sw.ToString());
        }

        [Fact]
        public void Test_For_3()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Fibonacci.PrintFibonnaciSequential(3);
            Assert.Equal("0 1 1 ", sw.ToString());
        }

        [Fact]
        public void Test_NthFib_1()
        {
            var a = Fibonacci.GetNthFibonacciRecursive(3);
            Assert.Equal(2, a);
        }

        [Fact]
        public void Test_NthFib_4()
        {
            var a = Fibonacci.GetNthFibonacciRecursive(4);
            Assert.Equal(3, a);
        }
    }
}
