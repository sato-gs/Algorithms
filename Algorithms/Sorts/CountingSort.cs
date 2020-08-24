namespace Algorithms.Sorts
{
    using System.Linq;

    public static class CountingSort
    {
        public static int[] Sort(int[] items)
        {
            // Work out minimum and maximum items
            var min = items.FirstOrDefault();
            var max = items.FirstOrDefault();
            for (var i = 0; i < items.Length; i++)
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

            // Count the number of times each item appears in the range of min - max
            var count = new int[max - min + 1];
            for (var j = 0; j < items.Length; j++)
            {
                count[items[j] - min]++;
            }

            // Sort items based on the count array
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