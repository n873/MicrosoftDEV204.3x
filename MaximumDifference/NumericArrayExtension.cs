using System.Collections.Generic;

namespace MaximumDifference
{
    public static class NumericArrayExtension
    {
        public static int MaximumDifference(this int[] a)
        {
            var differencesArray = new List<int>();

            for (var i = 0; i < a.Length; i++)
            {
                var focusValue = a[i];
                var excludedArray = new List<int>();

                foreach (var value in a)
                {
                    if (value != focusValue)
                        excludedArray.Add(value);
                }

                foreach (var value in excludedArray)
                {
                    var difference = 0;

                    if (value > focusValue)
                        difference = value - focusValue;
                    else
                        difference = focusValue - value;

                    if (!differencesArray.Contains(difference))
                        differencesArray.Add(difference);
                }
            }

            if (differencesArray.Count > 0)
            {
                int focusValue;

                for (var i = 1; i < differencesArray.Count; i++)
                {
                    focusValue = differencesArray[i];

                    var j = i;

                    while (j > 0 && differencesArray[j - 1] > focusValue)
                    {
                        differencesArray[j] = differencesArray[j - 1];

                        j--;
                    }
                    differencesArray[j] = focusValue;
                }
                return differencesArray[differencesArray.Count - 1];
            }

            return 0;
        }
    }
}
