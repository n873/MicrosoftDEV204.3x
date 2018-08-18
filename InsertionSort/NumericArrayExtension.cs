using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort.Extentions
{
    public static class NumericArrayExtension
    {
        public static int[] Sort(this int[] array) {
            try
            {
                // Declare variable for the insertion value
                int focusValue;

                // The outer loop allows us to iterate over the complete array
                // that we will use for sorting
                for (int i = 1; i < array.Length; i++)
                {
                    // set newValue equal to the second element in the array
                    // we don't start at the first element because it has no
                    // preceding value, which means we can't move it any further
                    // forward in the array
                    focusValue = array[i];

                    // Also set the start of our inner loop to the same value as i
                    int j = i;

                    // This loop will check the value of j to ensure we have not
                    // reached the end of the iteration (j = 0), but also checks
                    // to see if the value preceding the current value is larger.
                    // If it is, we "swap" the value before this one, decrement j,
                    // and then test againt the next value. This continues until
                    // we run out of numbers in the array (j=0) or there are no
                    // more values larger than the current number (newValue) to
                    // it's left (preceding it).
                    while (j > 0 && array[j - 1] > focusValue)
                    {
                        array[j] = array[j - 1];

                        j--;
                    }
                    array[j] = focusValue;
                }
                return array;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
