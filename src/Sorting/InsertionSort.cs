namespace Sorting;

public class InsertionSort
{
    // Insertion Sort Method
    public static void Sort(int[] arr)
    {
        for(int i = 1; i < arr.Length; i++)
        {
            int key = arr[i],
                j = i - 1;

            while(j >= 0 && arr[j] > key)
            {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = key;
        }
    }
}