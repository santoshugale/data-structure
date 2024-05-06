using Leetcode;
using Xunit;

namespace LeetCodeUnitTest
{
    public class StringProblemsTest
    {
        [Fact]
        public void StringTest()
        {
            var result = StringProblems.ReverseCharactersInString("abcd");
            Assert.Equal("dcba", result);

            result = StringProblems.ReverseCharactersInString("ab");

            Assert.Equal("ba", result);

            result = StringProblems.ReverseCharactersInString("cba");
            Assert.Equal("abc", result);

            result = StringProblems.ReverseCharactersInString("a");
            Assert.Equal("a", result);

            result = StringProblems.ReverseWorkdsInString("afirst bsecond cthird");
            Assert.Equal("cthird bsecond afirst", result);

            result = StringProblems.ReverseWorkdsInString("afirst cthird");
            Assert.Equal("cthird afirst", result);

            result = StringProblems.ReverseWorkdsInString("cthird");
            Assert.Equal("cthird", result);
        }

        [Fact]
        public static void NewMethod()
        {
            Assert.Equal(string.Empty, StringProblems.FindCommonLongPrefix(new string[] { "pune", "mumbai", "nashik" }));
            Assert.Equal("pu", StringProblems.FindCommonLongPrefix(new string[] { "pune", "pundharpur", "pule" }));
        }
    }
}
