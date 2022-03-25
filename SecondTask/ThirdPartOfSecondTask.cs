using System;
using System.Diagnostics;

namespace SecondTask
{
    /// <summary>
    /// Fills array by random numbers, and sums by rows and columns. Second Part of Second Task
    /// </summary>
    internal class ThirdPartOfSecondTask
    {
        /// <summary>
        /// Fills array by random values, calls methods according to direction
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="direction">How need to sum, by rows or by columns</param>
        /// <returns>Returns tuple of values, first ia array, second is elapsed time in TimeSpan type </returns>
        internal (int[][], TimeSpan) GetSum(int[][] array, DirectionToSum direction, int columns, int rows)
        {
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
                array[i] = new int[columns];
            }
            Console.WriteLine("");
            if (direction == DirectionToSum.SumByRows)
                sum = SumByRows(array, columns, rows);
            //else
            //    sum = SumByColumns(array, columns, rows);
            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            (int[][], TimeSpan) result = (sum, timeSpan);
            return result;
        }
        /// <summary>
        /// Sums by rows
        /// </summary>
        /// <param name="array"></param>
        private int[][] SumByRows(int[][] array, int columns, int rows)
        {
            Console.WriteLine("Sum by rows");
            int[][] secondArray = new int[1][];
            for (int i = 0; i < columns; i++)
            {
                array[i] = new int[columns];
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
        /// Sums by columns
        /// </summary>
        /// <param name="array"></param>
        //private int[][] SumByColumns(int[][] array, int columns, int rows)
        //{
        //    Console.WriteLine("Sum by columns");
        //    int[][] secondArray = new int[rows][];
        //    for (int i = 0; i < columns; i++)
        //    {
        //        array[i] = new int[columns];
        //    }
        //    for (int i = 0; i < rows; i++)
        //    {
        //        int temp = 0;
        //        for (int j = 0; j < columns; j++)
        //        {
        //            temp += array[i][j];
        //        }
        //        secondArray[i][0] = temp;
        //    }
        //    return secondArray;
        //}
    }
}


