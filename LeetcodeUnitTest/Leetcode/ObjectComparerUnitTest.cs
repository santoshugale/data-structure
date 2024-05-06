using Leetcode.Leetcode;
using Xunit;

namespace LeetcodeUnitTest.Leetcode
{
    public class ObjectComparerUnitTest
    {
        [Fact]
        public void TwoEqualInt()
        {
            Assert.True(ObjectComparer.Compare(1, 1));
        }

        [Fact]
        public void TwoUnequalInt()
        {
            Assert.False(ObjectComparer.Compare(11, 1));
        }
        [Fact]
        public void TwoEqualStrings()
        {
            Assert.True(ObjectComparer.Compare("1", "1"));
        }

        [Fact]
        public void TwoUnequalStrings()
        {
            Assert.False(ObjectComparer.Compare("11", "1"));
        }

        [Fact]
        public void TwoEqualDates()
        {
            var date = DateTime.Now;
            Assert.True(ObjectComparer.Compare(date, date));
        }

        [Fact]
        public void TwoUnequalDates()
        {
            var date = DateTime.Now;
            Thread.Sleep(1);
            Assert.False(ObjectComparer.Compare(DateTime.Now, date));
        }
        [Fact]
        public void TwoEqualEmployee()
        {
            var emp1 = new Employee(1, "santosh", 22, new Address(1, "state", "location"));
            var emp2 = new Employee(1, "santosh", 22, new Address(1, "state", "location"));
            Assert.True(ObjectComparer.Compare(emp1, emp2));
        }

        [Fact]
        public void TwoUnequalEmployee()
        {
            var emp1 = new Employee(1, "santosh", 22, new Address(1, "state", "location"));
            var emp2 = new Employee(2, "Ram", 22, new Address(1, "state", "location"));
            Assert.False(ObjectComparer.Compare(emp1, emp2));
        }

        [Fact]
        public void NullCompare()
        {
            Employee e = null;
            Assert.True(ObjectComparer.Compare(e, e));
        }

        [Fact]
        public void NullAndNotNullCompare()
        {
            Employee e = null;
            var e1 = new Employee(1, "santosh", 22, new Address(1, "state", "location"));
            Assert.False(ObjectComparer.Compare(e, e1));
            Assert.False(ObjectComparer.Compare(e1, e));
        }
    }
}
