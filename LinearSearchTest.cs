using System;

public class LinearSearchTest
{
    static void Main()
    {
        Random generator = new Random();
        int[] data = new int[10];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = generator.Next(10, 100);
        }

        Console.WriteLine(string.Join(" ", data));
        Console.WriteLine();

        Console.Write("Enter an integer value (-1 to quit): ");
        int searchInt = int.Parse(Console.ReadLine());

        while (searchInt != -1)
        {
            int position = LinearSearch(data, searchInt);

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

            Console.Write("Enter an integer value (-1 to quit): ");
            searchInt = int.Parse(Console.ReadLine());
        }
    }

    public static int LinearSearch(int[] values, int searchKey)
    {
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == searchKey)
            {
                return i;
            }
        }

        return -1;
    }
}
