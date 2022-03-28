using System;
using System.Diagnostics;
namespace SecondTask
{
    /// <summary>
    /// Fills array by random numbers, and sums by rows and columns
    /// </summary>
    internal class Calculator
    {
        /// <summary>
        /// Fills array by random numbers, call methods for sum by rows or columns, counts the time spent
        /// </summary>
        /// <param name="rows">Number of rows</param>
        /// <param name="columns">Number of columns</param>
        /// <returns>Returns the time spent on the calculation</returns>
        internal (int[,], TimeSpan) GetFirstPartSum(int[,] array, DirectionToSum direction)
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
            int[,] sum;
            Console.WriteLine("");
            if (direction == DirectionToSum.SumByRows)
                sum = SumByRows(array);
            else
                sum = SumByColumns(array);
            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            (int[,], TimeSpan) result = (sum, timeSpan);
            return result;
        }
        /// <summary>
        /// Fills jagged array by random values, calls methods according to direction
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="direction">How need to sum, by rows or by columns</param>
        /// <returns>Returns tuple of values, first ia array, second is elapsed time in TimeSpan type </returns>
        internal (int[][], TimeSpan) GetSecondPartSum(int[][] array, DirectionToSum direction, int columns, int rows)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("Second Part Output");
            Stopwatch time = new Stopwatch();
            time.Start();
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = random.Next(1, 5);
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine("");
            }
            int[][] sum = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                sum[i] = new int[1];
            }
            Console.WriteLine("");
            if (direction == DirectionToSum.SumByRows)
                sum = SumByRows(array, columns, rows);
            else
                sum = SumByColumns(array, columns, rows);
            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            (int[][], TimeSpan) result = (sum, timeSpan);
            return result;
        }
        /// <summary>
        /// Sums by rows, write result to console
        /// </summary>
        /// <param name="array"></param>
        private int[,] SumByRows(int[,] array)
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
            return secondArray;
        }
        /// <summary>
        /// Sums by columns, write result to console
        /// </summary>
        /// <param name="array"></param>
        private int[,] SumByColumns(int[,] array)
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
            return secondArray;
        }
 
        /// <summary>
        /// Sums jagged Array by rows
        /// </summary>
        /// <param name="array"></param>
        private int[][] SumByRows(int[][] array, int columns, int rows)
        {
            Console.WriteLine("Sum by rows");
            int[][] secondArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                secondArray[i] = new int[1];
            }
            for (int i = 0; i < rows; i++)
            {
                int temp = 0;
                for (int j = 0; j < columns; j++)
                {
                    temp += array[i][j];
                }
                secondArray[i][0] = temp;
            }
            return secondArray;
        }
        /// <summary>
        /// Sums jagged Array by columns
        /// </summary>
        /// <param name="array"></param>
        private int[][] SumByColumns(int[][] array, int columns, int rows)
        {
            Console.WriteLine("Sum by columns");
            int[][] secondArray = new int[1][];
            secondArray[0] = new int[columns];
            for (int i = 0; i < columns; i++)
            {
                int temp = 0;
                for (int j = 0; j < rows; j++)
                {
                    temp += array[j][i];
                }
                secondArray[0][i] = temp;
            }
            return secondArray;
        }
    }
}
