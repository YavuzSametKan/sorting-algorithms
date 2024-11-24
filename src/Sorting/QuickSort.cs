namespace Sorting
{
    public class QuickSort
    {
        // This method is called when the user just gives the array
        public static void Sort(int[] arr)
        {
            // Automatically determine the left and right values
            Sort(arr, 0, arr.Length - 1);
        }
        
        public static void Sort(
            int[] arr,
            int leftIndex,
            int rightIndex
        )
        {
            // Base case to terminate recursion if the left index is greater or equal to right
            if (leftIndex >= rightIndex) return;

            // Choose a pivot using the median of three method
            int pivotIndex = MedianOfThreePivot(arr, leftIndex, rightIndex);
            
            // Partition the array into two halves and recursively sort each half
            int newPivot = Partition(arr, leftIndex, rightIndex, pivotIndex);
            Sort(arr, leftIndex, newPivot - 1);
            Sort(arr, newPivot + 1, rightIndex);
        }

        // Partition the array and return the new pivot index after swapping elements
        private static int Partition(
            int[] arr,
            int leftIndex,
            int rightIndex,
            int pivotIndex
        )
        {
            int pivotValue = arr[pivotIndex];
            int i = leftIndex;
            int j = rightIndex - 1;

            // Move elements to the correct side of the pivot
            while (i <= j)
            {
                while (arr[i] < pivotValue) i++;
                while (arr[j] > pivotValue && j > leftIndex) j--;

                if (i <= j)
                {
                    // Swap the elements to their correct sides
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }

            // Move pivot element to its correct position
            Swap(arr, i, pivotIndex);
            return i;
        }

        // Swap elements in the array at positions i and j
        private static void Swap(int[] arr, int i, int j)
        {
            if (i != j)
                (arr[i], arr[j]) = (arr[j], arr[i]);
        }

        // Select the pivot using the median of three method (left, middle, right)
        private static int MedianOfThreePivot(int[] arr, int leftIndex, int rightIndex)
        {
            int middleIndex = (leftIndex + rightIndex) / 2;

            // Compare the left, middle, and right elements to choose a good pivot
            if (arr[leftIndex] > arr[middleIndex])
                Swap(arr, leftIndex, middleIndex);
            if (arr[leftIndex] > arr[rightIndex])
                Swap(arr, leftIndex, rightIndex);
            if (arr[middleIndex] > arr[rightIndex])
                Swap(arr, middleIndex, rightIndex);

            // Return the median index as the pivot
            return middleIndex;
        }
    }
}
