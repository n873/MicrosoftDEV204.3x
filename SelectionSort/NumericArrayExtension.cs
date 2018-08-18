
using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public static class NumericArrayExtension
    {
        public static void Sort(this int[] array) {
            try
            {
                //minPos will  keep track of where the minimum value is located
                int minPos;

                // temp is used for the swapping of values for the sort
                int temp;

                // outer loop will be responsible for ensuring we have iterated over the entire array
                for (int i = 0; i < array.Length - 1; i++)
                {
                    //set minPos to the current counter value for traversing the array
                    minPos = i;

                    // inner loop will perform the comparisons between the min and the other values in the array
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < array[minPos])
                        {
                            //minPos will keep track of the index that min is in, this is needed when a swap happens
                            minPos = j;
                        }
                    }

                    //if minPos no longer equals i, it indicates a smaller value existed so a swap must take place to sort the values
                    if (minPos != i)
                    {
                        temp = array[i];
                        array[i] = array[minPos];
                        array[minPos] = temp;
                    }
                }
            }
            catch (Exception) { throw; }
        }
    }
}
