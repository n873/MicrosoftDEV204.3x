using BubbleSort.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BubbleSort
{
    public class BubbleSortTest
    {
        private readonly int[] ballSizes;
        private readonly int[] ballSizesSortedAcsending;
        private readonly IEnumerable<IBall> bouncyBalls;
        private readonly IEnumerable<IBall> sortedBouncyBalls;
        private readonly IEnumerable<IBall> bouncyBallsSortedByAlgorithm;

        public BubbleSortTest()
        {
            #region Unsorted List of Bouncy Balls 
            var random = new Random();

            ballSizes = new int[6];

            for (var i = 0; i < 6; i++)
                ballSizes[i] = random.Next(1, 100);

            bouncyBalls = BouncyBallFactory.GenerateBouncyBalls(ballSizes);
            #endregion

            bouncyBallsSortedByAlgorithm = bouncyBalls.Sort();

            #region Sorted List of Bouncy Balls
            ballSizesSortedAcsending = new int[6];

            var sortedNumbersList = ballSizes.ToList();
            sortedNumbersList.Sort();

            ballSizesSortedAcsending = sortedNumbersList.ToArray();

            sortedBouncyBalls = BouncyBallFactory.GenerateBouncyBalls(ballSizesSortedAcsending);

            #endregion


        }

        [Fact]
        public void BallSortedAscendingTest()
        {
            var sortedBouncyBallsList = sortedBouncyBalls.ToList();
            var bouncyBallsSortedByAlgorithmList = bouncyBallsSortedByAlgorithm.ToList();
            for (var i = 0; i < sortedBouncyBallsList.Count; i++)
                Assert.Equal(sortedBouncyBallsList[i].Size, bouncyBallsSortedByAlgorithmList[i].Size);
        }

        [Fact]
        public void BallSizesSortedAscendingTest()
        {
            var bouncyBallSizesSortedByAlgorithm = bouncyBallsSortedByAlgorithm.ToSizeArray();
            var sortedBouncyBallSizes = sortedBouncyBalls.ToSizeArray();

            Assert.Equal(sortedBouncyBallSizes, bouncyBallSizesSortedByAlgorithm);
        }
    }
}
