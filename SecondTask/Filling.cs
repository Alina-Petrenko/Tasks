using System;
using System.Diagnostics;
namespace SecondTask
{
    // TODO: "Provides ability to fill various arrays."
    /// <summary>
    /// Fills array by random numbers, and call methods for sum by rows or columns
    /// </summary>
    // TODO: use public identifier. It is rare cases when need to use internal identifier. Read more about it in web or in "CLR via C#".
    internal class Filling
    {
        // TODO: split parts of class using regions (Fields, Constructors, Properties, Methods)
        // TODO: Good practice is explicitly indicate visibility of fields and methods. It should be written as:
        // private Stopwatch _time = new Stopwatch();
        // same for random. 
        Stopwatch time = new Stopwatch();
        Random random = new Random();
        // TODO: use constructor to provide related classes without which current class could not work
        Calculator calculator = new Calculator();
        /// <summary>
        /// Calls methods for filling two-dimensional arrays and calls methods for sum by rows or columns, counts the time spent
        /// </summary>
        /// <param name="array">Array of values</param>
        /// TODO: "identifies summing type of items in array"
        /// <param name="direction">Direction, how to Sum, by columns or by rows</param>
        /// <returns>Returns tuple with two-dimensional array and TimeSpan value</returns>
        internal (int[,], TimeSpan) GetFirstPartSum(int[,] array, DirectionToSum direction)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("First Part Output");
            time.Start();
            array = GetRandom(array);
            int[,] sum;
            Console.WriteLine("");
            // TODO: like an option write like this
            //  sum = direction == DirectionToSum.SumByRows ? calculator.SumByRows(array) : calculator.SumByColumns(array);
            if (direction == DirectionToSum.SumByRows)
                sum = calculator.SumByRows(array);
            else
                sum = calculator.SumByColumns(array);
            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            (int[,], TimeSpan) result = (sum, timeSpan);
            return result;
        }
        /// <summary>
        /// Calls methods for filling jagged array by random values, calls methods according to direction
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="direction">How need to sum, by rows or by columns</param>
        /// <returns>Returns tuple of values, first is a jagged array, second is elapsed time in TimeSpan type </returns>
        internal (int[][], TimeSpan) GetSecondPartSum(int[][] array, DirectionToSum direction, int columns, int rows)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("Second Part Output");
            time.Start();
            array = GetRandom(array, rows, columns);
            int[][] sum = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                sum[i] = new int[1];
            }
            Console.WriteLine("");
            if (direction == DirectionToSum.SumByRows)
                sum = calculator.SumByRows(array, columns, rows);
            else
                sum = calculator.SumByColumns(array, columns, rows);
            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            (int[][], TimeSpan) result = (sum, timeSpan);
            return result;
        }
        // TODO: make a new line separation between methods
        /// <summary>
        /// Calls methods for filling two-dimensional arrays and calls methods for sum by rows or columns, counts the time spent
        /// </summary>
        /// <param name="array"></param>
        /// <param name="operationOfNumbers">Which one operation method has to call, sum or subtraction</param>
        /// <returns>Returns tuple with two-dimensional array and TimeSpan value</returns>
        internal (int[,], TimeSpan) GetThirdPartSum(int[,] array, OperationOnNumbers operationOfNumbers)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("Third Part Output");
            time.Start();
            array = GetRandom(array);
            int[,] sumAboveDiagonal = calculator.GetArrayAboveDiagonal(array);
            int[,] sumUnderDiagonal = calculator.GetArrayUnderDiagonal(array);
            var sideDiagonalSum = calculator.GetsecondaryDiagonalSum(array);
            var newSize = sumAboveDiagonal.GetLength(0);
            int[,] sum = new int[newSize, 2];
            Console.WriteLine("");
            Console.WriteLine("Parallel Diagonals Sums from left-top to right-down");
            Console.WriteLine("Left row is above side Diagonal, right is under");
            if (operationOfNumbers == OperationOnNumbers.Sum)
                sum = calculator.GetSum(sumAboveDiagonal, sumUnderDiagonal, sideDiagonalSum);
            else
                sum = calculator.GetSubtraction(sumAboveDiagonal, sumUnderDiagonal, sideDiagonalSum);
            time.Stop();
            TimeSpan timeSpan = time.Elapsed;
            (int[,], TimeSpan) result = (sum, timeSpan);
            return result;
        }
        /// <summary>
        /// Fills two-dimensional array by random numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns two-dimentional array</returns>
        private int[,] GetRandom(int[,] array)
        {
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
            return array;
        }
        /// <summary>
        /// Fills jagged array by random numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns jagged array</returns>
        private int[][] GetRandom(int[][] array, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i][j] = random.Next(1, 5);
                    Console.Write($"{array[i][j]}\t");
                }
                Console.WriteLine("");
            }
            return array;
        }

    }
}
