namespace Algorithms.Searches
{
    public static class LinearSearch
    {
        public static int Search(int[] items, int target)
        {
            // Iterate over items starting with the first item
            for (var i = 0; i < items.Length; i++)
            {
                // If they match, return the position of the item
                if (items[i] == target)
                {
                    return i;
                }

                // If they do not match
                // Continue the search with the next item
            }

            // Return -1 if the target item does not exist
            return -1;
        }
    }
}