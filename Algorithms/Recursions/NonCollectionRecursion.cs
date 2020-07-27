namespace Algorithms.Recursions
{
    public static class NonCollectionRecursion
    {
        public static int Execute(int item)
        {
            // Define a base condition
            if (item <= 1)
            {
                return item;
            }

            // Define a recursive condition
            return item * Execute(item - 1);
        }
    }
}