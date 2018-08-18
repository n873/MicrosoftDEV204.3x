using System;

namespace LinearSearch
{
    public static class NumericArrayExtension
    {
        public static int Search(this int[] array, int term) {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    // if we found a match, we can return the index in the array where the term is
                    if (array[i] == term)
                    {
                        return i;
                    }
                }
                return -1;
            }
            catch (Exception) { throw; }
        }
    }
}
