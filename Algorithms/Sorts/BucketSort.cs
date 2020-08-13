namespace Algorithms.Sorts
{
    using System.Collections.Generic;

    public static class BucketSort
    {
        public static int[] Sort(int[] items)
        {
            // Create as many buckets as necessary for items to be distributed into
            var buckets = new List<int>[items.Length];

            // Initialize each bucket
            for (var i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<int>();
            }

            // Distribute each item into a bucket based on its hash value
            for (var j = 0; j < items.Length; j++)
            {
                buckets[Hash(items[j])].Add(items[j]);
            }

            // Sort items in each (non-empty) bucket
            foreach (var bucket in buckets)
            {
                // Sort() (in List) uses quick sort in C#
                bucket.Sort();
            }

            // Visit sorted buckets in order and concatenate them into one
            var index = 0;
            var sortedItems = new int[items.Length];
            for (var k = 0; k < buckets.Length; k++)
            {
                foreach (var item in buckets[k])
                {
                    sortedItems[index] = item;
                    index++;
                }
            }

            return sortedItems;
        }

        // Define the helper function to generate hash for each item (only workable between 0 - 99)
        public static int Hash(int item)
        {
            return item / 10 % 10;
        }
    }
}