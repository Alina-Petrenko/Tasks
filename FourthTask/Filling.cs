using System;
using System.Linq;

namespace FourthTask
{
    /// <summary>
    /// Provides ability to fill various arrays by random numbers
    /// </summary>
    public class Filling
    {
        private Random _random = new Random();
        /// <summary>
        /// Fills one dimensional array by random decimal numbers
        /// </summary>
        /// <param name="size">Size of array</param>
        /// <returns>Returns one dimensional array with random numbers</returns>
        public decimal[] GetRandomDecimalOneDimensionalArray(int size)
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
            Console.WriteLine("");
            return array;
        }

        /// <summary>
        /// Fills one dimensional array by random char numbers
        /// </summary>
        /// <param name="size">Size of array</param>
        /// <returns>Returns one dimensional array with random numbers</returns>
        public char[] GetRandomCharOneDimensionalArray(int size)
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
            Console.WriteLine("");
            return array;
        }

        /// <summary>
        /// Fills two dimensional array by random decimal numbers
        /// </summary>
        /// <param name="rows">Rows in array</param>
        /// <param name="columns">Columns in array</param>
        /// <returns>Returns two dimensional array with random numbers</returns>
        public decimal[,] GetRandomDecimalTwoDimensionalArray(int rows, int columns)
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
            Console.WriteLine("");
            return array;
        }

        /// <summary>
        /// Fills two dimensional array by random char numbers
        /// </summary>
        /// <param name="rows">Rows in array</param>
        /// <param name="columns">Columns in array</param>
        /// <returns>Returns two dimensional array with random numbers</returns>
        public char[,] GetRandomCharTwoDimensionalArray(int rows, int columns)
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
            Console.WriteLine("");
            return array;
        }

        /// <summary>
        /// Sorts ascending two dimensional decimal array
        /// </summary>
        /// <param name="array">Inputed two dimensional decimal array</param>
        /// <returns>Returns sorted ascending two dimensional array</returns>
        private decimal[,] GetSortDecimalTwoDemensionalArray(decimal[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            decimal[] newArray = new decimal[rows * columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newArray[i * columns + j] = array[i, j];
                }
            }
            Array.Sort(newArray);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = newArray[i * columns + j];
                }
            }
            return array;
        }

        /// <summary>
        /// Sorts ascending two dimensional char array
        /// </summary>
        /// <param name="array">Inputed two dimensional char array</param>
        /// <returns>Returns sorted ascending two dimensional array</returns>
        private char[,] GetSortCharTwoDemensionalArray(char[,] array)
        {
            var rows = array.GetLength(0);
            var columns = array.GetLength(1);
            char[] newArray = new char[rows * columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newArray[i * columns + j] = array[i, j];
                }
            }
            Array.Sort(newArray);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = newArray[i * columns + j];
                }
            }
            return array;
        }
    }
}
