using System;

namespace SecondTask
{
    /// <summary>
    /// Class outputs array to console
    /// </summary>
    internal class ArrayOutput
    {
        /// <summary>
        /// Method outputs array to console
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
                    Console.Write($"{array[i, j]}\t");
                }
            }
            Console.WriteLine("");
        }
        internal void GetArrayToConsoleByColumns(int[,] array)
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
    }
}
