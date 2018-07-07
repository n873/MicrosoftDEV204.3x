using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSort.Extensions
{
    public static class BallSizeExtension
    {
        public static int[] ToSizeArray(this IEnumerable<IBall> balls) {
            try
            {
                return ToSizeArray(balls.ToList());
            }
            catch (Exception) { throw; }
        }

        public static int[] ToSizeArray(this IBall[] balls) {
            try
            {
                return ToSizeArray(balls.ToList());
            }
            catch (Exception) { throw; }
        }

        public static int[] ToSizeArray(this List<IBall> balls) {
            try
            {
                var ballSizeArray = new int[balls.Count];
                for (var i = 0; i < balls.Count; i++)
                    ballSizeArray[i] = Int32.Parse(balls[i].Size.ToString());
                return ballSizeArray;
            }
            catch (Exception) { throw; }
        }
    }
}
