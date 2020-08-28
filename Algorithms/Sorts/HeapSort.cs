namespace Algorithms.Sorts
{
    public static class HeapSort
    {
        public static int[] Sort(int[] items)
        {
            var length = items.Length;
            // Build an initial max heap (e.g. all it requires to build a max heap is to heapify down for items between the right most sub-tree item and a root item)
            // (length / 2) - 1 gives the index of the right most sub-tree item
            for (var i = (length / 2) - 1; i >= 0; i--)
            {
                HeapifyDown(items, length, i);
            }

            // Iterate over items backwards
            for (var k = length - 1; k >= 0; k--)
            {
                // Swap the largest item with the current end of the list
                Swap(items, 0, k);
                // Heapify down from top to the current end of the list to maintain the max heap property (e.g. to push the largest item to the top)
                HeapifyDown(items, k, 0);
            }

            return items;
        }

        // Define the helper function to restructure top-down in such ways that the max heap property is maintained
        public static void HeapifyDown(int[] items, int length, int index)
        {
            var largest = index;
            var left = index * 2 + 1;
            var right = index * 2 + 2;

            // If a left child is larger than currently the largest item
            // Keep track of it
            if (left < length && items[left] > items[largest])
            {
                largest = left;
            }

            // If a right child is larger than currently the largest item
            // Keep track of it
            if (right < length && items[right] > items[largest])
            {
                largest = right;
            }

            // If the largest item is not a current item
            // Swap the largest item with the current one and continue recursively top-down
            if (largest != index)
            {
                Swap(items, index, largest);
                HeapifyDown(items, length, largest);
            }
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