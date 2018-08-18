using System;

namespace BinarySearch
{
    public static class NumericArrayExtension
    {
        public static int Search(this int[] array, int key) {
            try
            {
                var first = 0;
                var last = array.Length-1;

                while (first <= last)
                {
                    var mid = (first + last) / 2;


                    if (key == array[mid])
                        return mid;
                    else if (key < array[mid])
                        last = mid - 1;
                    else
                        first = mid + 1;
                }
                return -1;
            }
            catch (Exception) { throw; }
        }
    }
}
