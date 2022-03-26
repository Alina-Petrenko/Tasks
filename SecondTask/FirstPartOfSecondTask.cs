using System;
using System.Diagnostics;
namespace SecondTask
{
    /// <summary>
    /// Fills array by random numbers, and sums by rows and columns. First Part of Second Task
    /// </summary>
    internal class FirstPartOfSecondTask
    {       
        ArrayOutput arrayOutput = new ArrayOutput();
        /// <summary>
        /// Fills array by random numbers, call methods for sum by rows or columns, counts the time spent
        /// </summary>
        /// <param name="rows">Number of rows</param>
        /// <param name="columns">Number of columns</param>
        /// <returns>Returns the time spent on the calculation</returns>
        internal TimeSpan GetSum(int [,] array)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("First Part Output");
            Stopwatch time = new Stopwatch();
            time.Start();
            Random random = new Random();
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(1, 5);
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            SumByRows(array);
            SumByColumns(array);
            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            return timeSpan;
        }
        /// <summary>
        /// Sums by rows, write result to console
        /// </summary>
        /// <param name="array"></param>
        private void SumByRows(int[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            Console.WriteLine("Sum by rows");
            int[,] secondArray = new int[rows, 1];
            for (int i = 0; i < rows; i++)
            {
                var temp = 0;
                for (int j = 0; j < columns; j++)
                {
                    temp += array[i, j];
                }
                secondArray[i, 0] = temp;
            }
            arrayOutput.GetArrayToConsoleByColumns(secondArray);
            Console.WriteLine("");
        }
        /// <summary>
        /// Sums by columns, write result to console
        /// </summary>
        /// <param name="array"></param>
        private void SumByColumns(int[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            Console.WriteLine("Sum by columns");
            int[,] secondArray = new int[1, columns];
            for (int i = 0; i < columns; i++)
            {
                var temp = 0;
                for (int j = 0; j < rows; j++)
                {
                    temp += array[j, i];
                }
                secondArray[0, i] = temp; ;
            }
            arrayOutput.GetArrayToConsoleByRows(secondArray);
            Console.WriteLine("");
        }
    }
}
