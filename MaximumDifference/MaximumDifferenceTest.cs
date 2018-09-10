using Xunit;

namespace MaximumDifference
{
    public class MaximumDifferenceTest
    {
        [Theory]
        [InlineData(7, 3, 2, 9, 5)]
        [InlineData(0, 1, 1, 1, 1)]
        public void GetMaximumDifference(int expected, params int[] array)
        {
            Assert.Equal(expected, array.MaximumDifference());
        }
    }
}
