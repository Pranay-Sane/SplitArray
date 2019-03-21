using System;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Print2DArray(SplitArray(new string[] { "a", "b", "c", "d" }, 2));
            Print2DArray(SplitArray(new int[] { 0, 1, 2, 3, 4, 5 }, 3));
            Print2DArray(SplitArray(new int[] { 0, 1, 2, 3, 4, 5 }, 2));
            Print2DArray(SplitArray(new int[] { 0, 1, 2, 3, 4, 5 }, 4));
        }

        static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static T[,] SplitArray<T>(T[] arr, int size)
        {
            int rows = (arr.Length + size - 1) / size;
            T[,] result = new T[rows, size];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = arr[index];
                    index++;
                    if (index == arr.Length) break;
                }
            }
            return result;
        }
    }
}
