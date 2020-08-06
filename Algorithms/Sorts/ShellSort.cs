namespace Algorithms.Sorts
{
    public static class ShellSort
    {
        public static int[] Sort(int[] items)
        {
            // Start with a big gap and continue until the gap becomes 0
            for (var interval = items.Length / 2; interval > 0; interval /= 2)
            {
                // Iterate over items starting at the gap position
                for (var i = interval; i < items.Length; i++)
                {
                    var cur = items[i];
                    int j;
                    // Compare the current item with items at the gap positions (on the left side) backwards
                    // Keep shifting items smaller than the current item towards right
                    for (j = i; j >= interval && items[j - interval] > cur; j -= interval)
                    {
                        items[j] = items[j - interval];
                    }

                    // Insert the current item into the correct position
                    items[j] = cur;
                }
            }

            return items;
        }
    }
}