namespace Algorithms.Sorts
{
    public static class ShellSort
    {
        public static int[] Sort(int[] items)
        {
            // Start with a big gap and continue until the gap becomes 0
            for (var gap = items.Length / 2; gap > 0; gap /= 2)
            {
                // Iterate over items starting at the gap position
                for (var i = gap; i < items.Length; i++)
                {
                    var cur = items[i];
                    int j;
                    // Compare the current item with items at the gap positions (on the left side) backwards
                    // Keep shifting items smaller than the current item towards right
                    for (j = i; j >= gap && items[j - gap] > cur; j -= gap)
                    {
                        items[j] = items[j - gap];
                    }

                    // Insert the current item into the correct position
                    items[j] = cur;
                }
            }

            return items;
        }
    }
}