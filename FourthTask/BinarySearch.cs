using System;
using System.Diagnostics;

namespace FourthTask
{
    /// <summary>
    /// Provides a mechanism for binary searching inputed arrays 
    /// </summary>
    public class BinarySearch
    {
        private Stopwatch _oneDimentionalTime = new Stopwatch();
        private Stopwatch _twoDimentionalTime = new Stopwatch();
        private TimeSpan _timeSpan = new TimeSpan();

        /// <summary>
        /// Uses a binary search mechanism for getting index of searched Value from one dimensional decimal array
        /// </summary>
        /// <param name="array">Inputed one dimensional decimal array</param>
        /// <param name="searchedValue">Searched value</param>
        /// <param name="firstIndex">First index of array</param>
        /// <param name="lastIndex">Last index  of array</param>
        /// <returns>Returns tuple, first value is required index, second value is elapsed time in TimeSpan type</returns>
        public (int, TimeSpan) GetBinarySearchInOneDimensionalDecimalArray(decimal[] array, decimal searchedValue, int firstIndex, int lastIndex)
        {
            _oneDimentionalTime.Start();
            var middleIndex = (firstIndex + lastIndex) / 2;
            if (firstIndex > lastIndex)
            {
                _oneDimentionalTime.Stop();
                _timeSpan = _oneDimentionalTime.Elapsed;
                return (-1, _timeSpan);
            }

            if (array[middleIndex].Equals(searchedValue))
            {
                _oneDimentionalTime.Stop();
                _timeSpan = _oneDimentionalTime.Elapsed;
                return (middleIndex, _timeSpan);
            }
            else if
                (searchedValue > array[middleIndex])
            {
                firstIndex = middleIndex + 1;
                return GetBinarySearchInOneDimensionalDecimalArray(array, searchedValue, firstIndex, lastIndex);
            }
            else
            {
                lastIndex = middleIndex - 1;
                return GetBinarySearchInOneDimensionalDecimalArray(array, searchedValue, firstIndex, lastIndex);
            }
            
        }

        /// <summary>
        /// Uses a binary search mechanism for getting index of searched Value from one dimensional char array
        /// </summary>
        /// <param name="array">Inputed one dimensional char array</param>
        /// <param name="searchedValue">Searched value</param>
        /// <param name="firstIndex">First index of array</param>
        /// <param name="lastIndex">Last index  of array</param>
        /// <returns>Returns tuple, first value is required index, second value is elapsed time in TimeSpan type</returns>
        public (int, TimeSpan) GetBinarySearchInOneDimensionalCharArray(char[] array, char searchedValue, int firstIndex, int lastIndex)
        {
            var middleIndex = (firstIndex + lastIndex) / 2;
            if (firstIndex > lastIndex)
            {
                _oneDimentionalTime.Stop();
                _timeSpan = _oneDimentionalTime.Elapsed;
                return (-1, _timeSpan);
            }

            if (array[middleIndex].Equals(searchedValue))
            {
                _oneDimentionalTime.Stop();
                _timeSpan = _oneDimentionalTime.Elapsed;
                return (middleIndex, _timeSpan);
            }
            else if
                (searchedValue > array[middleIndex])
            {
                firstIndex = middleIndex + 1;
                return GetBinarySearchInOneDimensionalCharArray(array, searchedValue, firstIndex, lastIndex);
            }
            else
            {
                lastIndex = middleIndex - 1;
                return GetBinarySearchInOneDimensionalCharArray(array, searchedValue, firstIndex, lastIndex);
            }
        }
        /// <summary>
        /// Uses a binary search mechanism for getting index of searched Value from two dimensional decimal array
        /// </summary>
        /// <param name="array">Inputed two dimensional decimal array</param>
        /// <param name="searchedValue">Searched value</param>
        /// <param name="firstIndex">First index of array</param>
        /// <param name="lastIndex">Last index  of array</param>
        /// <returns>Returns tuple, first value is required row index, second value is required column index, third value is elapsed time in TimeSpan type</returns>
        public (int, int, TimeSpan) GetBinarySearchInTwoDimensionalDecimalArray(decimal[,] array, decimal searchedValue, int firstIndex, int lastIndex)
        {
            _twoDimentionalTime.Start();
            var columnsSize = array.GetLength(1);
            var middleRowIndex = ((firstIndex + lastIndex) / 2) / columnsSize;
            var middleColumnsIndex = (columnsSize - 1) / 2;
            if (firstIndex > lastIndex)
            {
                _twoDimentionalTime.Stop();
                _timeSpan = _twoDimentionalTime.Elapsed;
                return (-1, -1, _timeSpan);
            }

            if (array[middleRowIndex, middleColumnsIndex].Equals(searchedValue))
            {
                _twoDimentionalTime.Stop();
                _timeSpan = _twoDimentionalTime.Elapsed;
                return (middleRowIndex, middleColumnsIndex, _timeSpan);
            }
            else if (searchedValue < array[middleRowIndex, 0])
            {
                lastIndex = (middleRowIndex * columnsSize) - 1;
                return GetBinarySearchInTwoDimensionalDecimalArray(array, searchedValue, firstIndex, lastIndex);

            }
            else if (searchedValue > array[middleRowIndex, columnsSize - 1])
            {
                firstIndex = (middleRowIndex * columnsSize) + 1;
                return GetBinarySearchInTwoDimensionalDecimalArray(array, searchedValue, firstIndex, lastIndex);
            }
            else if (searchedValue > array[middleRowIndex, 0] && (searchedValue < array[middleRowIndex, columnsSize - 1]))
            {
                decimal[] newArray = new decimal[lastIndex + 1];
                for (int i = 0; i < columnsSize - 1; i++)
                {
                    newArray[i] = array[middleRowIndex, i];
                }
                firstIndex = 0;
                lastIndex = columnsSize - 1;
                var (index, _) = GetBinarySearchInOneDimensionalDecimalArray(newArray, searchedValue, firstIndex, lastIndex);
                _twoDimentionalTime.Stop();
                _timeSpan = _twoDimentionalTime.Elapsed;
                return (middleRowIndex, index, _timeSpan);
            }

            else if (searchedValue == array[middleRowIndex, 0] || searchedValue == array[middleRowIndex, columnsSize - 1])
            {
                if (searchedValue == array[middleRowIndex, 0])
                {
                    _twoDimentionalTime.Stop();
                    _timeSpan = _twoDimentionalTime.Elapsed;
                    return (middleRowIndex, 0, _timeSpan);
                }
                else
                {
                    _twoDimentionalTime.Stop();
                    _timeSpan = _twoDimentionalTime.Elapsed;
                    return (middleRowIndex, columnsSize - 1, _timeSpan);
                }
            }
            _twoDimentionalTime.Stop();
            _timeSpan = _twoDimentionalTime.Elapsed;
            return (-1, -1, _timeSpan);
        }

        /// <summary>
        /// Uses a binary search mechanism for getting index of searched Value from two dimensional char array
        /// </summary>
        /// <param name="array">Inputed two dimensional char array</param>
        /// <param name="searchedValue">Searched value</param>
        /// <param name="firstIndex">First index of array</param>
        /// <param name="lastIndex">Last index  of array</param>
        /// <returns>Returns tuple, first value is required row index, second value is required column index, third value is elapsed time in TimeSpan type</returns>

        public (int, int, TimeSpan) GetBinarySearchInTwoDimensionalCharArray(char[,] array, char searchedValue, int firstIndex, int lastIndex)
        {
            _twoDimentionalTime.Start();
            var columnsSize = array.GetLength(1);
            var middleRowIndex = ((firstIndex + lastIndex) / 2) / columnsSize;
            var middleColumnsIndex = (columnsSize - 1) / 2;
            if (firstIndex > lastIndex)
            {
                _twoDimentionalTime.Stop();
                _timeSpan = _twoDimentionalTime.Elapsed;
                return (-1, -1, _timeSpan);
            }

            if (array[middleRowIndex, middleColumnsIndex].Equals(searchedValue))
            {
                _twoDimentionalTime.Stop();
                _timeSpan = _twoDimentionalTime.Elapsed;
                return (middleRowIndex, middleColumnsIndex, _timeSpan);
            }
            else if (searchedValue < array[middleRowIndex, 0])
            {
                lastIndex = (middleRowIndex * columnsSize) - 1;
                return GetBinarySearchInTwoDimensionalCharArray(array, searchedValue, firstIndex, lastIndex);

            }
            else if (searchedValue > array[middleRowIndex, columnsSize - 1])
            {
                firstIndex = (middleRowIndex * columnsSize) + 1;
                return GetBinarySearchInTwoDimensionalCharArray(array, searchedValue, firstIndex, lastIndex);
            }
            else if (searchedValue > array[middleRowIndex, 0] && (searchedValue < array[middleRowIndex, columnsSize - 1]))
            {
                char[] newArray = new char[lastIndex + 1];
                for (int i = 0; i < columnsSize - 1; i++)
                {
                    newArray[i] = array[middleRowIndex, i];
                }
                firstIndex = 0;
                lastIndex = columnsSize - 1;
                var (index, _) = GetBinarySearchInOneDimensionalCharArray(newArray, searchedValue, firstIndex, lastIndex);
                _twoDimentionalTime.Stop();
                _timeSpan = _twoDimentionalTime.Elapsed;
                return (middleRowIndex, index,_timeSpan);
            }

            else if (searchedValue == array[middleRowIndex, 0] || searchedValue == array[middleRowIndex, columnsSize - 1])
            {
                if (searchedValue == array[middleRowIndex, 0])
                {
                    _twoDimentionalTime.Stop();
                    _timeSpan = _twoDimentionalTime.Elapsed;
                    return (middleRowIndex, 0, _timeSpan);
                }
                else
                {
                    _twoDimentionalTime.Stop();
                    _timeSpan = _twoDimentionalTime.Elapsed;
                    return (middleRowIndex, columnsSize - 1, _timeSpan);
                }
            }
            _twoDimentionalTime.Stop();
            _timeSpan = _twoDimentionalTime.Elapsed;
            return (-1, -1, _timeSpan);
        }
    }
}



