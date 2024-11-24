using System.Diagnostics;
using Utils.ArrayUtils;
using Sorting;

class Program{

    public static void InsertionSortDemo(int[]? arr = null, bool printing = true){
        // If there is no array, generate a random array
        if (arr == null) 
            arr = ArrayUtils.GenerateArr(10, low: 0, high: 100);
        
        // Calculating to working time
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        // Sorting
        InsertionSort.Sort(arr);
        
        // Calculating is finish
        stopwatch.Stop();
        
        // Working time
        Console.WriteLine($"Insertion Sort: {stopwatch.Elapsed} time");
        
        if (printing) // Printing array to console
            ArrayUtils.PrintArr(arr);
    }
    
    public static void MergeSortDemo(int[]? arr = null, bool printing = true){
        // If there is no array, generate a random array
        if (arr == null) 
            arr = ArrayUtils.GenerateArr(10, low: 0, high: 100);
        
        // Calculating to working time
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        // Sorting
        MergeSort.Sort(arr);
        
        // Calculating is finish
        stopwatch.Stop();
        
        // Working time
        Console.WriteLine($"Merge Sort: {stopwatch.Elapsed} time");
        
        if (printing) // Printing array to console
            ArrayUtils.PrintArr(arr);
    }
    
    public static void QuickSortDemo(int[]? arr = null, bool printing = true){
        // If there is no array, generate a random array
        if (arr == null) 
            arr = ArrayUtils.GenerateArr(10, low: 0, high: 100);
        
        // Calculating to working time
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        // Sorting
        QuickSort.Sort(arr);
        
        // Calculating is finish
        stopwatch.Stop();

        // Working time
        Console.WriteLine($"Quick Sort: {stopwatch.Elapsed} time");
        
        if (printing) // Printing array to console
            ArrayUtils.PrintArr(arr);
    }


    public static void Main(string[] args)
    {
        int[] arr = ArrayUtils.GenerateArr(
            arrSize: 100000,
            low: 0,
            high: 9999999
        );
        
        Array.Sort(arr);
        Array.Reverse(arr);
        
        InsertionSortDemo(arr, printing: false);
        MergeSortDemo(arr, printing: false);
        QuickSortDemo(arr, printing: false);
    }
}
