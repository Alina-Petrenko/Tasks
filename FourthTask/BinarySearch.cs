
namespace FourthTask
{
    public class BinarySearch
    {
        public int GetBinarySearchInOneDimensionalDecimalArray(decimal[] array, decimal searchedValue, int firstIndex, int lastIndex)
        {
            var middleIndex = (firstIndex + lastIndex) / 2;
            if (firstIndex > lastIndex)
            {
                return -1;
            }

            if (array[middleIndex].Equals(searchedValue))
            {
                return middleIndex;
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
        public int GetBinarySearchInOneDimensionalCharArray(char[] array, char searchedValue, int firstIndex, int lastIndex)
        {
            var middleIndex = (firstIndex + lastIndex) / 2;
            if (firstIndex > lastIndex)
            {
                return -1;
            }

            if (array[middleIndex].Equals(searchedValue))
            {
                return middleIndex;
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
        public (int, int) GetBinarySearchInTwoDimensionalDecimalArray(decimal[,] array, decimal searchedValue, int firstIndex, int lastIndex)
        {
            var columnsSize = array.GetLength(1);
            var middleRowIndex = ((firstIndex + lastIndex) /2)/columnsSize;
            var middleColumnsIndex = (columnsSize - 1) / 2; 
            if (firstIndex > lastIndex)
            {
                return (-1, -1);
            }

            if (array[middleRowIndex, middleColumnsIndex].Equals(searchedValue))
            {
                return (middleRowIndex, middleColumnsIndex);
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
                var index = GetBinarySearchInOneDimensionalDecimalArray(newArray, searchedValue, firstIndex, lastIndex);
                return (middleRowIndex, index);
            }
            
            else if (searchedValue == array[middleRowIndex, 0] || searchedValue == array[middleRowIndex, columnsSize - 1])
            {
                if (searchedValue == array[middleRowIndex, 0])
                {
                    return (middleRowIndex, 0);
                }
                else
                {
                    return (middleRowIndex, columnsSize - 1);
                }
            }
            return (-1, -1);
        }
        public (int, int) GetBinarySearchInTwoDimensionalCharArray(char[,] array, char searchedValue, int firstIndex, int lastIndex)
        {
            var columnsSize = array.GetLength(1);
            var middleRowIndex = ((firstIndex + lastIndex) / 2) / columnsSize;
            var middleColumnsIndex = (columnsSize - 1) / 2;
            if (firstIndex > lastIndex)
            {
                return (-1, -1);
            }

            if (array[middleRowIndex, middleColumnsIndex].Equals(searchedValue))
            {
                return (middleRowIndex, middleColumnsIndex);
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
                var index = GetBinarySearchInOneDimensionalCharArray(newArray, searchedValue, firstIndex, lastIndex);
                return (middleRowIndex, index);
            }

            else if (searchedValue == array[middleRowIndex, 0] || searchedValue == array[middleRowIndex, columnsSize - 1])
            {
                if (searchedValue == array[middleRowIndex, 0])
                {
                    return (middleRowIndex, 0);
                }
                else
                {
                    return (middleRowIndex, columnsSize - 1);
                }
            }
            return (-1, -1);
        }
    }
}



