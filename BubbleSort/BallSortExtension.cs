using System;
using System.Collections.Generic;
using System.Linq;

namespace BubbleSort.Extensions
{
    public static class BallSortExtension
    {
        public static IEnumerable<IBall> Sort(this IEnumerable<IBall> balls)
        {
            try
            {
                return Sort(balls.ToList());
            }
            catch (Exception) { throw; }
        }

        public static IBall[] Sort(this IBall[] balls)
        {
            try
            {
                return Sort(balls.ToList()).ToArray();
            }
            catch (Exception) { throw; }
        }

        public static List<IBall> Sort(this List<IBall> balls)
        {
            try
            {
                // Use this to know when to stop the sorting routine
                bool swapped;

                // Here we use a do loop but could have used for or while loops as well
                do
                {
                    // Set swapped to false so that that we can ensure at least one pass on the array
                    swapped = false;

                    // This loop will iterate over the array from beginning to end
                    for (var i = 0; i < balls.Count - 1; i++)
                    {
                        // Here we use the i for the position in the array
                        // So i is the first value to compare and i+1 compares the adjacent valie
                        // Once i is incremented at the end of this loop, we compare the next two sets of values, etc.
                        if (balls[i].Size > balls[i + 1].Size)
                        {
                            // Swap routine. Could be seperate method as well but it used inline for simplicity here
                            // ballPlaceHolder is used to hold the right value in the comparison so we don't lose it.
                            // That value will be replaced in the next step
                            var ballPlaceHolder = balls[i + 1];

                            // Here we replace the right value with the larger value that was on the left
                            // See why we need the ballPlaceHolder variable above?
                            balls[i + 1] = balls[i];

                            // Now we assign the value that is in ballPlaceHolder, the smaller value, to the location that was just vacates by the larger number
                            balls[i] = ballPlaceHolder;

                            // Indicate that we did a swap, which means we need to continue to check the remaining values.
                            swapped = true;
                        }
                    }
                } while (swapped == true);

                return balls;
            }
            catch (Exception) { throw; }
        }
    }
}
