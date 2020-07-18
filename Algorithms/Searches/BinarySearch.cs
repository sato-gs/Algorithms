namespace Algorithms.Searches
{
    public static class BinarySearch
    {
        public static int Search(int[] items, int target)
        {
            var low = 0;
            var high = items.Length - 1;

            while (low <= high)
            {
                var middle = (low + high) / 2;
                if (target == items[middle])
                {
                    return middle;
                }
                else if (target < items[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return -1;
        }
    }
}