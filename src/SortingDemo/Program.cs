using Utils.ArrayUtils;
using Sorting;

class Program{

    public static void InsertionSortDemo(){
        // Generate array for insertion sort
        var arr = ArrayUtils.GenerateArr(arrSize: 8, low: 0, high: 100);
        
        // Sorting
        InsertionSort.Sort(arr);

        // Printing to console
        Console.WriteLine("Insertion Sort:");
        ArrayUtils.PrintArr(arr);
    }

    public static void Main(string[] args){
        InsertionSortDemo();
    }
}
