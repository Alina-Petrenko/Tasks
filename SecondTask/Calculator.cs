using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    // TODO: typo issue: "necessary" instead of "nessesary"
    /// <summary>
    /// Calculates nessesary values according to direction or operation
    /// </summary>
    internal class Calculator
    {
        // TODO: method return a value. Describe it in section <returns></returns>.
        // TODO: if you use <param> then need to fill it. In your case: "Array to operate" or "Input array".
        /// <summary>
        /// TODO: this method does not write result into console
        /// Sums two-dimensional array by rows, write result to console
        /// </summary>
        /// <param name="array"></param>
        internal int[,] SumByRows(int[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            // TODO: use new lines to split logical parts of the methods (input, parsing values, calculations, output etc).
            // TODO: it is related to all code.
            Console.WriteLine("Sum by rows");
            int[,] secondArray = new int[rows, 1];
            for (int i = 0; i < rows; i++)
            {
                // TODO: better name is "rowSum"
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
        /// Sums two-dimensional array by columns, write result to console
        /// </summary>
        /// <param name="array"></param>
        internal int[,] SumByColumns(int[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            Console.WriteLine("Sum by columns");
            int[,] secondArray = new int[1, columns];
            for (int i = 0; i < columns; i++)
            {
                // TODO: better name is "columnSum"
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
        internal int[][] SumByRows(int[][] array, int columns, int rows)
        {
            // TODO: There is array.GetLength() method. You don`t need columns and rows input parameters
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
        internal int[][] SumByColumns(int[][] array, int columns, int rows)
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
        /// <summary>
        /// Sums Diagonals above secondary diagonal
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns array of diaginals sums</returns>
        internal int[,] GetArrayAboveDiagonal(int[,] array)
        {
            var size = array.GetLength(0);
            int[,] secondArray = new int[size - 1, 1];
            for (int i = 0; i < size - 1; i++)
            {
                var index = 0;
                var temp = 0;
                for (int j = size - 2 - i; j >= 0; j--)
                {
                    temp += array[index, j];
                    index++;
                }
                secondArray[size - 2 - i, 0] = temp;
            }
            return secondArray;
        }
        /// <summary>
        /// Sums Diagonals under secondary diagonal
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns array of diagonals sums</returns>
        internal int[,] GetArrayUnderDiagonal(int[,] array)
        {
            var size = array.GetLength(0);
            int[,] secondArray = new int[size - 1, 1];
            for (int i = 0; i < size - 1; i++)
            {
                var index = 1 + i;
                var temp = 0;
                for (int j = size - 1; j > 0 + i; j--)
                {
                    temp += array[index, j];
                    index++;
                }
                secondArray[i, 0] = temp;
            }
            return secondArray;
        }
        /// <summary>
        /// Sums secondary diagonal values
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns array of diagonals sums</returns>
        internal int GetsecondaryDiagonalSum(int[,] array)
        {
            var size = array.GetLength(0);
            var secondaryDiagonalSum = 0;
            var index = 0;
            for (int i = size - 1; i >= 0; i--)
            {
                secondaryDiagonalSum += array[i, index];
                index++;
            }
            return secondaryDiagonalSum;
        }
        /// <summary>
        /// Subtraction of values ​​of parallel diagonals with secondary
        /// </summary>
        /// <param name="sumAboveDiagonal"></param>
        /// <param name="sumUnderDiagonal"></param>
        /// <param name="secondaryDiagonalSum"></param>
        /// <returns>Returns array of subtract result</returns>
        internal int[,] GetSubtraction(int[,] sumAboveDiagonal, int[,] sumUnderDiagonal, int secondaryDiagonalSum)
        {
            var size = sumAboveDiagonal.GetLength(0);
            int[,] resultArray = new int[size, 2];
            for (int i = 0; i < size; i++)
            {
                resultArray[i, 0] = secondaryDiagonalSum - sumAboveDiagonal[i, 0];
                resultArray[i, 1] = secondaryDiagonalSum - sumUnderDiagonal[i, 0];
            }
            return resultArray;
        }
        /// <summary>
        /// Sum of values ​​of parallel diagonals with secondary
        /// </summary>
        /// <param name="sumAboveDiagonal"></param>
        /// <param name="sumUnderDiagonal"></param>
        /// <param name="secondaryDiagonalSum"></param>
        /// <returns>Returns array of sum result</returns>
        internal int[,] GetSum(int[,] sumAboveDiagonal, int[,] sumUnderDiagonal, int secondaryDiagonalSum)
        {
            var size = sumAboveDiagonal.GetLength(0);
            int[,] resultArray = new int[size, 2];
            Console.WriteLine($"Secondary diagonal = {secondaryDiagonalSum}");
            for (int i = 0; i < size; i++)
            {
                resultArray[i, 0] = sumAboveDiagonal[i, 0] + secondaryDiagonalSum;
                resultArray[i, 1] = sumUnderDiagonal[i, 0] + secondaryDiagonalSum;
            }
            return resultArray;
        }
    }
}
