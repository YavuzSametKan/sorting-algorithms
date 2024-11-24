namespace Sorting;

public class MergeSort
{
    // Merge Sort Methods
    public static void Sort(int[] arr)
    {
        int arrLen = arr.Length;
        
        if(arrLen < 2) return;

        int midIndex = arr.Length / 2;
        int[] leftHalf = new int[midIndex];
        int[] rightHalf = new int[arrLen - midIndex];

        // leftHalf[0,...,midIndex-1] <- arr[0,...,midIndex-1]
        for(int i = 0; i < midIndex; i++)
            leftHalf[i] = arr[i];
        
         // rightHalf[0,...,midIndex] <- arr[midIndex,...,arrLen-1]
        for(int i = midIndex; i < arrLen; i++)
            rightHalf[i - midIndex] = arr[i];
        
        Sort(leftHalf);
        Sort(rightHalf);
        Merge(arr, leftHalf, rightHalf);
    }

    private static void Merge(int[] arr, int[] leftHalf, int[] rightHalf)
    {
        int leftLen = leftHalf.Length,
            rightLen = rightHalf.Length;
        
        int i = 0, // Counter floating in the left half array.
            j = 0, // Counter floating in the right half array.
            k = 0; // Counter floating in the array.

        while(i < leftLen && j < rightLen)
        {
            if(leftHalf[i] <= rightHalf[j])
            {
                arr[k] = leftHalf[i];
                i++;
            } 
            else 
            {
                arr[k] = rightHalf[j];
                j++;    
            }
            k++;
        }

        // Copy Remaining Elements
        // After the comparison loop, any remaining elements in either the left or right subarray
        // are already sorted and can be directly copied to the main array.         

        while(i < leftLen) // Copy remaining elements from the left subarray
        {
            arr[k] = leftHalf[i];
            i++;
            k++;
        }

        while(j < rightLen) // Copy remaining elements from the right subarray
        {
            arr[k] = rightHalf[j];
            j++;
            k++;
        }
    }
}