namespace Algorithms.Sorts
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] items)
        {
            // Start at 0 (as unsorted items (on the right side))
            for (var i = 0; i < items.Length; i++)
            {
                // Select the first item of unsorted items as minimum
                var min = i;
                // Iterate over unsorted items
                for (var j = i + 1; j < items.Length; j++)
                {
                    // If the current item is less than the current minimum item
                    // Keep track of it
                    if (items[j] < items[min])
                    {
                        min = j;
                    }
                }

                // If the minimum item has changed
                // Swap it with the beginning of unsorted items
                if (i != min)
                {
                    Swap(items, i, min);
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