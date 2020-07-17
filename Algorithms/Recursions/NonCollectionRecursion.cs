namespace Algorithms.Recursions
{
    public static class NonCollectionRecursion
    {
        public static int Execute(int item)
        {
            if (item <= 1)
            {
                return item;
            }

            return item * Execute(item - 1);
        }
    }
}