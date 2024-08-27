using Xunit;

namespace Leetcode.Leetcode.Easy
{
    public class MergeTwoArrayTests
    {
        [Fact]
        public void Merge_ShouldReturnMergedArray()
        {
            // Arrange
            int[] array1 = { 1, 3, 5 };
            int[] array2 = { 2, 4, 6 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };

            // Act
            int[] result = MergeTwoArray.Merge(array1, array2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Merge_ShouldReturnArray1_WhenArray2IsEmpty()
        {
            // Arrange
            int[] array1 = { 1, 3, 5 };
            int[] array2 = { };
            int[] expected = { 1, 3, 5 };

            // Act
            int[] result = MergeTwoArray.Merge(array1, array2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Merge_ShouldReturnArray2_WhenArray1IsEmpty()
        {
            // Arrange
            int[] array1 = { };
            int[] array2 = { 2, 4, 6 };
            int[] expected = { 2, 4, 6 };

            // Act
            int[] result = MergeTwoArray.Merge(array1, array2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
