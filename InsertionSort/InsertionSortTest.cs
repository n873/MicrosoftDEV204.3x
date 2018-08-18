using InsertionSort.Extentions;
using System;
using Xunit;

namespace InsertionSort
{
    public class InsertionSortTest
    {
        private readonly int[] numericArray;
        private readonly int[] NumericArraySortedAscending;

        public InsertionSortTest()
        {
            var random = new Random();

            numericArray = new int[10];

            for (var i = 0; i < 10; i++)
                numericArray[i] = random.Next(1, 100);

            NumericArraySortedAscending = numericArray ;

            NumericArraySortedAscending.Sort();
        }

        [Fact]
        public void SortNumericArray()
        {
            Assert.Equal(numericArray, NumericArraySortedAscending);
        }
    }
}
