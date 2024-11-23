namespace Utils.ArrayUtils;

public class ArrayUtils
{
    // Method to generate a random array of integers
    public static int[] GenerateArr(int arrSize, int low = 0, int high = 9999999)
    {
        Random random = new Random();
        int[] arr = new int[arrSize];

        for (int i = 0; i < arr.Length; i++)
            arr[i] = random.Next(low, high);

        return arr;
    }

    // Method to print the array in a single line (comma separated)
    public static void PrintArr(int[] arr)
    {
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }

    // Method to print the array, each element on a new line
    public static void PrintArrByLine(int[] arr)
    {
        Console.WriteLine(string.Join("\n", arr));
    }
}
