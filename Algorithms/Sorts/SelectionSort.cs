namespace Algorithms.Sorts
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] items)
        {
            // Define the first index of the unsorted items to which the minimum item can be pushed
            for (var i = 0; i < items.Length; i++)
            {
                // Pick the first item of the unsorted items as minimum
                var min = i;
                // Iterate over all unsorted items
                for (var j = i + 1; j < items.Length; j++)
                {
                    // If the current item is less than the current minimum item
                    // keep track of it
                    if (items[j] < items[min])
                    {
                        min = j;
                    }
                }

                // If the minimum item has changed from the first item
                // swap it to the beginning of the unsorted items
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