namespace Algorithms.Sorts
{
    public static class QuickSort
    {
        public static int[] Sort(int[] items, int low, int high)
        {
            if (low < high)
            {
                // Reorder items and get the pivot index
                var pivot = ReOrder(items, low, high);

                // Recursively reorder the lower list (from beginning to the pivot)
                Sort(items, low, pivot - 1);
                // Recursively reorder the upper list (from the pivot to end)
                Sort(items, pivot + 1, high);
            }

            return items;
        }

        // Define the helper function to reorder items according to whether items are less/greater than the pivot item
        public static int ReOrder(int[] items, int low, int high)
        {
            // Define the pivot index to keep track of and select the starting index as pivot index first
            var pivotIndex = low;
            for (var i = low + 1; i <= high; i++)
            {
                // If the current item is less than the pivot item
                // Increment the pivot index and swap the current item with the item at the pivot index
                if (items[i] < items[low])
                {
                    pivotIndex++;
                    Swap(items, pivotIndex, i);
                }
            }

            // Swap the pivot item with the item at the pivot index (the right most item of the less than list) at the end of iteration
            Swap(items, low, pivotIndex);
            // Return the pivot index
            return pivotIndex;
        }

        // Define the helper function to swap items
        public static void Swap(int[] items, int index1, int index2)
        {
            var temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }
    }
}