using System;

public class BinarySearchTest
{
    static void Main()
    {
        Random generator = new Random();
        int[] data = new int[15];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = generator.Next(10, 100);
        }

        Array.Sort(data);
        DisplayElements(data, 0, data.Length - 1);

        Console.Write("\nPlease enter an integer value (-1 to quit): ");
        int searchInt = int.Parse(Console.ReadLine());

        while (searchInt != -1)
        {
            int position = BinarySearch(data, searchInt);

            if (position >= 0)
            {
                Console.WriteLine(
                    $"The integer {searchInt} was found in position {position}.\n");
            }
            else
            {
                Console.WriteLine(
                    $"The integer {searchInt} was not found.\n");
            }

            Console.Write("Please enter an integer value (-1 to quit): ");
            searchInt = int.Parse(Console.ReadLine());
        }
    }

    public static int BinarySearch(int[] values, int key)
    {
        int low = 0;
        int high = values.Length - 1;

        while (low <= high)
        {
            int middle = (low + high + 1) / 2;

            DisplayElements(values, low, high);
            Console.WriteLine("-- ".PadLeft((middle + 1) * 3));

            if (values[middle] == key)
            {
                return middle;
            }
            else if (key < values[middle])
            {
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }
        }

        return -1;
    }

    public static void DisplayElements(int[] values, int low, int high)
    {
        Console.Write(string.Empty.PadLeft(low * 3));

        for (int i = low; i <= high; i++)
        {
            Console.Write($"{values[i]} ");
        }

        Console.WriteLine();
    }
}
