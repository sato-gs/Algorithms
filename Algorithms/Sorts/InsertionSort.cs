namespace Algorithms.Sorts
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] items)
        {
            // Iterate over the unsorted items (on the right side)
            for (var i = 1; i < items.Length; i++)
            {
                // Compare it with the sorted items (on the left side) backwards
                // Keep swapping the position of two items until the current item is inserted into the correct position
                for (var j = i - 1; j > 0 && items[j] < items[j - 1]; j--)
                {
                    Swap(items, j, j - 1);
                }
            }

            return items;
        }

        // Define the helper function to swap items
        public static void Swap(int[] items, int index1, int index2)
        {
            var temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
    }
}