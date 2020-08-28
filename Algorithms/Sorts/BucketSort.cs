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

            // Distribute each item into buckets based on its hash value
            for (var j = 0; j < items.Length; j++)
            {
                buckets[Hash(items[j])].Add(items[j]);
            }

            // Sort items in each bucket
            foreach (var bucket in buckets)
            {
                // Sort() in List uses quick sort in C#
                bucket.Sort();
            }

            // Visit buckets in order and concatenate them into one
            var index = 0;
            foreach (var bucket in buckets)
            {
                foreach (var item in bucket)
                {
                    items[index++] = item;
                }
            }

            return items;
        }

        // Define the helper function to generate hash for each item (only workable between 0 - 99)
        public static int Hash(int item)
        {
            return item / 10 % 10;
        }
    }
}