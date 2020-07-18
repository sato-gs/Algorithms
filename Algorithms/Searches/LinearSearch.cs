namespace Algorithms.Searches
{
    public static class LinearSearch
    {
        public static int Search(int[] items, int target)
        {
            for (var i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}