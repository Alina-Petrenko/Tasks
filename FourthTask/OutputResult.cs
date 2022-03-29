
using System;

namespace FourthTask
{
    /// <summary>
    /// Provide method to Output results to console
    /// </summary>
    internal class OutputResult
    {
        private BinarySearch _binarySearch = new BinarySearch();

        /// <summary>
        /// Writes results to the console from binary search in decimal arrays
        /// </summary>
        /// <param name="decimalOneDimensionalArray">Decimal One Dimensional Array</param>
        /// <param name="decimalTwoDimensionalArray">Decimal Two Dimensional Array</param>
        /// <param name="searchedDecimalValue">Searched Decimal Value</param>
        public void GetDecimalResultToConsole(decimal[] decimalOneDimensionalArray, decimal[,] decimalTwoDimensionalArray, decimal searchedDecimalValue)
        {
            int firstIndex = 0;
            int lastOneDimensionalArrayIndex = decimalOneDimensionalArray.Length - 1;
            int lastTwoDimensionalArrayIndex = decimalTwoDimensionalArray.Length - 1;

            var (decimalOneDimensionalArrayIndex, decimalOneDimensionalArrayTime) = _binarySearch.GetBinarySearchInOneDimensionalDecimalArray(decimalOneDimensionalArray, searchedDecimalValue, firstIndex, lastOneDimensionalArrayIndex);
            if (decimalOneDimensionalArrayIndex < 0)
            {
                Console.WriteLine($"The one dimensional decimal array doesn't consist value '{searchedDecimalValue}'");
            }
            else
            {
                var elapsedDecimalOneDimensionalArrayTime = decimalOneDimensionalArrayTime.ToString(@"mm\:ss\.FFFFFF");
                Console.WriteLine($"Result from one dimensional decimal array: '{decimalOneDimensionalArray[decimalOneDimensionalArrayIndex]}' Index: {decimalOneDimensionalArrayIndex}, Time: {elapsedDecimalOneDimensionalArrayTime} ");
            }

            var (decimalTwoDimensionalArrayRow, decimalTwoDimensionalArrayColumn, decimalTwoDimensionalArrayTime) = _binarySearch.GetBinarySearchInTwoDimensionalDecimalArray(decimalTwoDimensionalArray, searchedDecimalValue, firstIndex, lastTwoDimensionalArrayIndex);
            if (decimalTwoDimensionalArrayColumn < 0)
            {
                Console.WriteLine($"The two dimensional decimal array doesn't consist value '{searchedDecimalValue}'");
            }
            else
            {
                var elapsedDecimalTwoDimensionalArrayTime = decimalTwoDimensionalArrayTime.ToString(@"mm\:ss\.FFFFFF");
                Console.WriteLine($"Result from two dimensional decimal array: '{decimalTwoDimensionalArray[decimalTwoDimensionalArrayRow, decimalTwoDimensionalArrayColumn]}', Index: {decimalTwoDimensionalArrayRow},{decimalTwoDimensionalArrayColumn}, Time: {elapsedDecimalTwoDimensionalArrayTime}");
            }
        }

        /// <summary>
        /// Writes results to the console from binary search in char arrays
        /// </summary>
        /// <param name="decimalOneDimensionalArray">Char One Dimensional Array</param>
        /// <param name="decimalTwoDimensionalArray">Char Two Dimensional Array</param>
        /// <param name="searchedDecimalValue">Searched Char Value</param>
        public void GetCharResultToConsole(char[] charOneDimensionalArray, char[,] charTwoDimensionalArray, char searchedCharValue)
        {
            int firstIndex = 0;
            int lastOneDimensionalArrayIndex = charOneDimensionalArray.Length - 1;
            int lastTwoDimensionalArrayIndex = charTwoDimensionalArray.Length - 1;
            var (charOneDimensionalArrayIndex, charOneDimensionalArrayTime) = _binarySearch.GetBinarySearchInOneDimensionalCharArray(charOneDimensionalArray, searchedCharValue, firstIndex, lastOneDimensionalArrayIndex);
            if (charOneDimensionalArrayIndex < 0)
            {
                Console.WriteLine($"The one dimensional char array doesn't consist value '{searchedCharValue}'");
            }
            else
            {
                var elapsedCharOneDimensionalArrayTime = charOneDimensionalArrayTime.ToString(@"mm\:ss\.FFFFFF");
                Console.WriteLine($"Result from one dimensional char array: '{charOneDimensionalArray[charOneDimensionalArrayIndex]}' Index {charOneDimensionalArrayIndex}, Time: {elapsedCharOneDimensionalArrayTime} ");
            }
            var (charTwoDimensionalArrayRow, charTwoDimensionalArrayColumn, charTwoDimensionalArrayTime) = _binarySearch.GetBinarySearchInTwoDimensionalCharArray(charTwoDimensionalArray, searchedCharValue, firstIndex, lastTwoDimensionalArrayIndex);
            if (charTwoDimensionalArrayColumn < 0)
            {
                Console.WriteLine($"The two dimensional char array doesn't consist value '{searchedCharValue}'");
            }
            else
            {
                var elapsedCharTwoDimensionalArrayTime = charTwoDimensionalArrayTime.ToString(@"mm\:ss\.FFFFFF");
                Console.WriteLine($"Result from two dimensional char array: '{charTwoDimensionalArray[charTwoDimensionalArrayRow, charTwoDimensionalArrayColumn]}' Index: {charTwoDimensionalArrayRow},{charTwoDimensionalArrayColumn}, Time: {elapsedCharTwoDimensionalArrayTime}");
            }
        }
    }
}
