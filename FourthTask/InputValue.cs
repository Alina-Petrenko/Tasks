using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    internal class InputValue
    {
        private BinarySearch _binarySearch = new BinarySearch();
        private Random _random = new Random();
        public void GetInputedValue()
        {
            var appIsRunning = true;
            while (appIsRunning)
            {
                Console.Write("Size of one-dimensional array: ");
                var resultOfParsing = int.TryParse(Console.ReadLine(), out var size);
                if (!resultOfParsing && (size <= 0))
                {
                    GetErrorMessage();
                    continue;
                }
                Console.Write("Rows of two-dimensional array: ");
                resultOfParsing = int.TryParse(Console.ReadLine(), out var rows);
                if (!resultOfParsing && (rows <= 0))
                {
                    GetErrorMessage();
                    continue;
                }
                Console.Write("Columns of two-dimensional array: ");
                resultOfParsing = int.TryParse(Console.ReadLine(), out var columns);
                if (!resultOfParsing && (columns <= 0))
                {
                    GetErrorMessage();
                    continue;
                }

                Console.WriteLine("");
                decimal[] decimalOneDimensionalArray = GetRandomDecimalOneDimensionalArray(size);
                Console.WriteLine("");
                char[] charOneDimensionalArray = GetRandomCharOneDimensionalArray(size);
                Console.WriteLine("");
                decimal[,] decimalTwoDimensionalArray = GetRandomDecimalTwoDimensionalArray(rows, columns);
                Console.WriteLine("");
                char[,] charTwoDimensionalArray = GetRandomCharTwoDimensionalArray(rows, columns);

                Console.WriteLine("");
                Console.Write("Searched decimal value: ");
                resultOfParsing = decimal.TryParse(Console.ReadLine(), out var searchedDecimalValue);
                if (!resultOfParsing)
                {
                    GetErrorMessage();
                    continue;
                }
                Console.WriteLine("");
                Console.Write("Searched char value: ");
                resultOfParsing = char.TryParse(Console.ReadLine(), out var searchedCharValue);
                if (!resultOfParsing)
                {
                    GetErrorMessage();
                    continue;
                }
                Console.WriteLine("");
                int firstIndex = 0;
                int lastOneDimensionalArrayIndex = decimalOneDimensionalArray.Length - 1;
                int lastTwoDimensionalArrayIndex = decimalTwoDimensionalArray.Length - 1;
                var decimalOneDimensionalArrayResult = _binarySearch.GetBinarySearchInOneDimensionalDecimalArray(decimalOneDimensionalArray, searchedDecimalValue, firstIndex, lastOneDimensionalArrayIndex);
                Console.WriteLine($"{decimalOneDimensionalArray[decimalOneDimensionalArrayResult]} Index: {decimalOneDimensionalArrayResult}");
                var charOneDimensionalArrayResult = _binarySearch.GetBinarySearchInOneDimensionalCharArray(charOneDimensionalArray, searchedCharValue, firstIndex, lastOneDimensionalArrayIndex);
                Console.WriteLine($"{charOneDimensionalArray[charOneDimensionalArrayResult]} Index {charOneDimensionalArrayResult}");
                var decimalTwoDimensionalArrayResult = _binarySearch.GetBinarySearchInTwoDimensionalDecimalArray(decimalTwoDimensionalArray, searchedDecimalValue, firstIndex, lastTwoDimensionalArrayIndex);
                Console.WriteLine($"{decimalTwoDimensionalArray[decimalTwoDimensionalArrayResult.Item1, decimalTwoDimensionalArrayResult.Item2]} Index: {decimalTwoDimensionalArrayResult.Item1},{decimalTwoDimensionalArrayResult.Item2}");
                var charTwoDimensionalArrayResult = _binarySearch.GetBinarySearchInTwoDimensionalCharArray(charTwoDimensionalArray, searchedCharValue, firstIndex, lastTwoDimensionalArrayIndex);
                Console.WriteLine($"{charTwoDimensionalArray[charTwoDimensionalArrayResult.Item1, charTwoDimensionalArrayResult.Item2]} Index: {charTwoDimensionalArrayResult.Item1},{charTwoDimensionalArrayResult.Item2}");

            }
        }

        /// <summary>
        /// Fills jagged array by random numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns jagged array</returns>
        private decimal[] GetRandomDecimalOneDimensionalArray(int size)
        {
            decimal[] array = new decimal[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = _random.Next(1, 101);
            }
            Array.Sort(array);
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            }
            return array;
        }

        /// <summary>
        /// Fills jagged array by random numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns jagged array</returns>
        private char[] GetRandomCharOneDimensionalArray(int size)
        {
            char[] array = new char[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = (char)_random.Next('a', 'z');
            }
            Array.Sort(array);
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            }
            return array;
        }

        /// <summary>
        /// Fills jagged array by random numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns jagged array</returns>
        private decimal[,] GetRandomDecimalTwoDimensionalArray(int rows, int columns)
        {
            decimal[,] array = new decimal[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = _random.Next(1, 101);
                }
            }
            array = GetSortDecimalTwoDemensionalArray(array);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} ");
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
        private char[,] GetRandomCharTwoDimensionalArray(int rows, int columns)
        {
            char[,] array = new char[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = (char)_random.Next('a', 'z');
                }
            }
            GetSortCharTwoDemensionalArray(array);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine("");
            }
            return array;
        }

        private decimal[,] GetSortDecimalTwoDemensionalArray(decimal[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            for (int i = rows * columns - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (array[j / columns, j % columns] > array[i / columns, i % columns])
                    {
                        var x = array[j / columns, j % columns];
                        array[j / columns, j % columns] = array[i / columns, i % columns];
                        array[i / columns, i % columns] = x;
                    }
            return array;
        }
        private char[,] GetSortCharTwoDemensionalArray(char[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            for (int i = rows * columns - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (array[j / columns, j % columns] > array[i / columns, i % columns])
                    {
                        var x = array[j / columns, j % columns];
                        array[j / columns, j % columns] = array[i / columns, i % columns];
                        array[i / columns, i % columns] = x;
                    }
            return array;
        }

        /// <summary>
        /// Writes an error message, if value was wrong
        /// </summary>
        /// 
        private void GetErrorMessage()
        {
            Console.WriteLine("Looks like wrong value, try again");
            Console.WriteLine("_________________________________");
        }
    }
}
