using Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Leetcode.Easy;

namespace LeetcodeUnitTest.Easy
{
    public class CoderFriendTest
    {
        [Fact]
        public void Winner_Return_Ty()
        {
            var result = CoderFriend.Winner("EEE", "EEE");
            Assert.Equal("Ty", result);
        }

        [Fact]
        public void Winner_Return_Erica()
        {
            var result = CoderFriend.Winner("EHM", "MEE");
            Assert.Equal("Erica", result);
        }


        [Fact]
        public void Winner_Return_Bob()
        {
            var result = CoderFriend.Winner("EHE", "HHE");
            Assert.Equal("Bob", result);
        }
    }
}
