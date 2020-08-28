namespace Algorithms.Sorts
{
    public static class CountingSort
    {
        public static int[] Sort(int[] items)
        {
            // Work out minimum and maximum numbers
            var min = items[0];
            var max = items[0];
            for (var i = 1; i < items.Length; i++)
            {
                if (min > items[i])
                {
                    min = items[i];
                }
                if (max < items[i])
                {
                    max = items[i];
                }
            }

            // Count the number of times each number appears in the range of min - max
            var count = new int[max - min + 1];
            for (var j = 0; j < items.Length; j++)
            {
                count[items[j] - min]++;
            }

            // Sort numbers based on the count array
            var counter = 0;
            for (var k = min; k <= max; k++)
            {
                while (count[k - min]-- > 0)
                {
                    items[counter++] = k;
                }
            }

            return items;
        }
    }
}