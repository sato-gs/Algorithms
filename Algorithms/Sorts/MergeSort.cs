namespace Algorithms.Sorts
{
    public static class MergeSort
    {
        public static int[] Sort(int[] items)
        {
            if (items.Length <= 1)
            {
                return items;
            }

            // Get the middle index of the list
            var middle = items.Length / 2;

            // Get the left half of the list
            var left = new int[middle];
            for (var i = 0; i < middle; i++)
            {
                left[i] = items[i];
            }

            // Get the right half of the list
            var right = new int[items.Length - middle];
            for (var i = middle; i < items.Length; i++)
            {
                right[i - middle] = items[i];
            }

            // Recursively split the list into halves until each sub-list contains only one element
            // Recursively merge sub-lists to produce newly sorted sub-lists until there is only one sorted list
            return Merge(Sort(left), Sort(right));
        }

        // Define the helper function to merge two sorted lists into one sorted list
        public static int[] Merge(int[] left, int[] right)
        {
            var result = new int[left.Length + right.Length];
            var leftIndex = 0;
            var rightIndex = 0;

            while (leftIndex < left.Length || rightIndex < right.Length)
            {
                if (leftIndex < left.Length && rightIndex < right.Length)
                {
                    if (left[leftIndex] < right[rightIndex])
                    {
                        result[leftIndex + rightIndex] = left[leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        result[leftIndex + rightIndex] = right[rightIndex];
                        rightIndex++;
                    }
                }
                else if (leftIndex < left.Length)
                {
                    result[leftIndex + rightIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[leftIndex + rightIndex] = right[rightIndex];
                    rightIndex++;
                }
            }

            return result;
        }
    }
}