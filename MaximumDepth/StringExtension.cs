namespace MaximumDepth
{
    public static class StringExtension
    {
        public static int MaximumDepth(this string s, char depthEntry, char depthEnd) {
            var currentMax = 0; //current count
            var max = 0; //overall maximum count

            //Traverse the input string
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == depthEntry)
                {
                    currentMax++;

                    //update max if required
                    if (currentMax > max)
                        max = currentMax;
                }
                else if (s[i] == depthEnd)
                {
                    if (currentMax > 0)
                        currentMax--;
                    else
                        return 0;
                }
            }

            //check for unbalanced string
            if (currentMax != 0)
                return 0;

            return max;
        }
    }
}
