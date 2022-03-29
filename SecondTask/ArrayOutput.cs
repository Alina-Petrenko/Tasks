using System;

namespace SecondTask
{
    /// <summary>
    /// Class outputs array to console
    /// </summary>
    internal class ArrayOutput
    {
        /// <summary>
        /// Method outputs two-dimensional array to console by Rows
        /// </summary>
        /// <param name="array"></param>
        internal void GetArrayToConsoleByRows(int[,]array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{array[i, j]}\t");
                }
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// Method outputs two-dimensional array to console by Columns
        /// </summary>
        /// <param name="array"></param>
        internal void GetArrayToConsoleByColumns(int[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// Method outputs jagged array to console by Rows
        /// </summary>
        /// <param name="array"></param>
        internal void GetJaggedArrayToConsoleByRows(int[][] array)
        {
            var rows = array.Length;
            var columns = array[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"{array[i][j]}\t");
                }
            }
            Console.WriteLine("");
        }
        /// <summary>
        /// Method outputs jagged array to console by Rows
        /// </summary>
        /// <param name="array"></param>
        internal void GetJaggedArrayToConsoleByColumns(int[][] array)
        {
            var rows = array.Length;
            var columns = array[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
            }
            Console.WriteLine("");
        }
    }
}
