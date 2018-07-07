using System;
using System.Collections.Generic;

namespace BubbleSort
{
    public static class BouncyBallFactory
    {
        public static IEnumerable<IBall> GenerateBouncyBalls(params int[] ballSizes) {
            try
            {
                if (ballSizes.Length > 0)
                {
                    var bouncyBalls = new List<IBall>();
                    foreach (var size in ballSizes) {
                        bouncyBalls.Add(new BouncyBall(size));
                    }
                    return bouncyBalls;
                }
                throw new Exception("No ball sizes were supplied, unable generate bouncy balls for those sizes.");
            }
            catch (Exception) { throw; }
        }
    }
}
