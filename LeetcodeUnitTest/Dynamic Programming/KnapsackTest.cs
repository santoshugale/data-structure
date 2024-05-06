using Leetcode.DynamicProgramming;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace LeetcodeTest.Dynamic_Programming
{
    public class KnapsackTest
    {
        [Fact]
        public void Knapsack_0_1()
        {
            Knapsack.Knapsack_0_1(new int[] { 1, 2, 3 }, new int[] { 4, 5, 1 }, 4, 3).Should().Be(0);
        }
    }
}
