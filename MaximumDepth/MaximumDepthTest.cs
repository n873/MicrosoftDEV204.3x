using Xunit;

namespace MaximumDepth
{
    public class MaximumDepthTest
    {
        [Theory]
        [InlineData(2, "a(())b()")]
        [InlineData(0, "(()1()")]
        public void GetMaximumDepth(int expected, string s)
        {
            Assert.Equal(expected, s.MaximumDepth('(', ')'));
        }
    }
}
