using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[,] randomArray = GenerateRandomArray(4, 5);

        Console.WriteLine("Tablica 2-wymiarowa:");
        PrintArray(randomArray);

        int[] closestRows = FindClosestRows(randomArray);
        Console.WriteLine($"Najbardziej zbliżone wiersze: {closestRows[0]}, {closestRows[1]}");
    }

    public static int[] FindClosestRows(int[,] array)
    {
        int rows = array.GetLength(0);
        int[] closestRows = new int[2];
        int minDifference = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < rows; j++)
            {
                int difference = CalculateRowDifference(array, i, j);
                if (difference < minDifference)
                {
                    minDifference = difference;
                    closestRows[0] = i;
                    closestRows[1] = j;
                }
            }
        }

        return closestRows;
    }

    public static int CalculateRowDifference(int[,] array, int i, int j)
    {
        int columns = array.GetLength(1);
        int difference = 0;

        for (int k = 0; k < columns; k++)
        {
            int elementDifference = array[i, k] - array[j, k];
            difference += elementDifference * elementDifference;
        }

        return difference;
    }

    public static int[,] GenerateRandomArray(int rows, int columns)
    {
        Random random = new Random();
        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(10);
            }
        }

        return array;
    }

    public static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
