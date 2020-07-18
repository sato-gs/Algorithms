namespace Algorithms.Searches
{
    public static class BinarySearch
    {
        public static int Search(int[] items, int target)
        {
            var low = 0;
            var high = items.Length - 1;

            // Continue the search until the list contains no item
            while (low <= high)
            {
                // Find the middle most index/item
                var middle = (low + high) / 2;

                // If they match, return the position of the item
                if (target == items[middle])
                {
                    return middle;
                }
                // If the target item is less than the middle most item
                // continue the search with the lower half of the list
                else if (target < items[middle])
                {
                    high = middle - 1;
                }
                // If the target item is greater than the middle most item
                // continue the search with the upper half of the list
                else
                {
                    low = middle + 1;
                }
            }

            // Return -1 if the target item does not exist
            return -1;
        }
    }
}