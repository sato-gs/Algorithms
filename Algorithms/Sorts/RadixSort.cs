namespace Algorithms.Sorts
{
    public static class RadixSort
    {
        public static int[] Sort(int[] items)
        {
            // Work out a maximum number
            var max = items[0];
            for (var i = 1; i < items.Length; i++)
            {
                if (max < items[i])
                {
                    max = items[i];
                }
            }

            // Go through numbers digit by digit (from lowest to highest)
            for (var exp = 1; max / exp > 0; exp *= 10)
            {
                var output = new int[items.Length];
                var count = new int[10];

                // Count the number of times each number appears in the range of 0 - 9
                for (var i = 0; i < items.Length; i++)
                {
                    // Get the number of the current digit
                    var num = items[i] / exp % 10;
                    count[num]++;
                }

                // Restructure the count array to contain actual positions (although actual position + 1) for the output array
                for (var k = 1; k < count.Length; k++)
                {
                    count[k] += count[k - 1];
                }

                // Build the output array
                for (var j = items.Length - 1; j >= 0; j--)
                {
                    output[(count[items[j] / exp % 10]) - 1] = items[j];
                    count[items[j] / exp % 10]--;
                }

                // Copy the output array to the original array so it contains sorted numbers according to the current digit
                for (var index = 0; index < items.Length; index++)
                {
                    items[index] = output[index];
                }
            }

            return items;
        }
    }
}