namespace Algorithms.Sorts
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] items)
        {
            // Iterate for items - 1 times
            for (var i = items.Length - 1; i > 0; i--)
            {
                // Define the flag to check whether or not swap has been made
                var swap = false;

                // Iterate over non bubbled up items
                for (var j = 0; j < i; j++)
                {
                    // If adjacent items are in the wrong order
                    // swap them and set the flag to true
                    if (items[j] > items[j + 1])
                    {
                        Swap(items, j, j + 1);
                        swap = true;
                    }
                }

                // Break out of the iteration if no swap has been made (meaning that items have been sorted)
                if (!swap)
                {
                    break;
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