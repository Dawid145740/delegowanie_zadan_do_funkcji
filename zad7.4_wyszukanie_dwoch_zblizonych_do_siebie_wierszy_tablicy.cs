using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array =
        {
            {1, 2, 3, 4, 5},
            {6, 7, 8, 9, 0},
            {10, 11, 12, 13, 14},
            {1, 3, 3, 4, 5}
        };

        Console.WriteLine("Wygenerowana tablica:");
        PrintArray(array);

        FindMostSimilarRows(array, out int row1, out int row2);

        Console.WriteLine($"Najbardziej podobne wiersze: {row1} i {row2}");
    }

    static void FindMostSimilarRows(int[,] array, out int row1, out int row2)
    {
        row1 = 0;
        row2 = 0;
        long smallestDifference = long.MaxValue;

        int numRows = array.GetLength(0);

        for (int i = 0; i < numRows - 1; i++)
        {
            for (int j = i + 1; j < numRows; j++)
            {
                long difference = CalculateDifference(array, i, j);

                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                    row1 = i;
                    row2 = j;
                }
            }
        }
    }

    static long CalculateDifference(int[,] array, int row1, int row2)
    {
        int numCols = array.GetLength(1);
        long difference = 0;

        for (int k = 0; k < numCols; k++)
        {
            difference += (long)Math.Pow(array[row1, k] - array[row2, k], 2);
        }

        return difference;
    }

    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
