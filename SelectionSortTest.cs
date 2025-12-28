using System;

public class SelectionSortTest
{
    static void Main()
    {
        Random random = new Random();
        int[] data = new int[10];

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = random.Next(10, 100);
        }

        Console.WriteLine("Unsorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n");

        SelectionSort(data);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", data) + "\n");
    }

    public static void SelectionSort(int[] values)
    {
        for (int i = 0; i < values.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < values.Length; j++)
            {
                if (values[j] < values[minIndex])
                {
                    minIndex = j;
                }
            }

            Swap(ref values[i], ref values[minIndex]);
            PrintPass(values, i + 1, minIndex);
        }
    }

    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void PrintPass(int[] values, int pass, int index)
    {
        Console.Write($"after pass {pass}: ");

        for (int i = 0; i < index; i++)
        {
            Console.Write($"{values[i]}  ");
        }

        Console.Write($"{values[index]}* ");

        for (int i = index + 1; i < values.Length; i++)
        {
            Console.Write($"{values[i]}  ");
        }

        Console.Write("\n              ");

        for (int i = 0; i < pass; i++)
        {
            Console.Write("--  ");
        }

        Console.WriteLine("\n");
    }
}
