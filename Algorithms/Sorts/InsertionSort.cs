namespace Algorithms.Sorts
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] items)
        {
            // Start at 1 (as unsorted items (on the right side))
            for (var i = 1; i < items.Length; i++)
            {
                var cur = items[i];
                int j;
                // Compare the current item with sorted items (on the left side) backwards
                // Keep shifting items larger than the current item towards right
                for (j = i; j > 0 && items[j - 1] > cur; j--)
                {
                    items[j] = items[j - 1];
                }

                // Insert the current item into the correct position
                items[j] = cur;
            }

            return items;
        }
    }
}