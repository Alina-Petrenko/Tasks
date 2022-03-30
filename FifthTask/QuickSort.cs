using System;
using System.Diagnostics;

namespace FifthTask
{
    /// <summary>
    /// Provides a mechanism for Quick Sort array 
    /// </summary>
    public class QuickSort
    {
        private TimeSpan _timeSpan = new TimeSpan();
        private Stopwatch _stopwatch = new Stopwatch();
        /// <summary>
        /// Calls methods for sorting array and calculating elapsed time
        /// </summary>
        /// <param name="array">One-dimensional array with random numbers</param>
        /// <param name="indexFromLeft">Calculation start index on the left</param>
        /// <param name="indexFromRight">Calculation start index on the right</param>
        /// <returns>Returns spent time for calculations</returns>
        public TimeSpan GetStartQuickSort(int[] array, int indexFromLeft, int indexFromRight)
        {
            _stopwatch.Start();
            Sort(array, indexFromLeft, indexFromRight);
            _stopwatch.Stop();
            _timeSpan = _stopwatch.Elapsed;
            return _timeSpan;

        }

        /// <summary>
        /// Sorts <paramref name="array"/> using given boundary indexes <paramref name="indexFromLeft"/> and <paramref name="indexFromRight"/>
        /// </summary>
        /// <param name="array">One-dimensional array with random numbers</param>
        /// <param name="indexFromLeft">Calculation start index on the left</param>
        /// <param name="indexFromRight">Calculation start index on the right</param>
        private void Sort(int[] array, int indexFromLeft, int indexFromRight)
        {
            var referenceNumber = 0;
            if (indexFromLeft < indexFromRight)
            {
                referenceNumber = SplitValues(array, indexFromLeft, indexFromRight);
                if (referenceNumber > 1)
                {
                    Sort(array, indexFromLeft, referenceNumber - 1);
                }
                if (referenceNumber + 1 < indexFromRight)
                {
                    Sort(array, referenceNumber + 1, indexFromRight);
                }
            }
        }
        /// <summary>
        /// Splits the <paramref name="array"/> in half, where the value on the left is less than the reference Number and the value on the right is greater
        /// </summary>
        /// <param name="array">One-dimensional array with random numbers</param>
        /// <param name="indexFromLeft">Calculation start index on the left</param>
        /// <param name="indexFromRight">Calculation start index on the right</param>
        /// <returns>Returns next start index on the right</returns>
        private int SplitValues(int[] array, int indexFromLeft, int indexFromRight)
        {
            var referenceNumber = array[indexFromLeft];
            var success = true;
            while (success)
            {
                while (array[indexFromRight] > referenceNumber)
                {
                    indexFromRight--;
                }
                while (array[indexFromLeft] < referenceNumber)
                {
                    indexFromLeft++;
                }
                if (indexFromLeft < indexFromRight)
                {
                    if (array[indexFromLeft] == array[indexFromRight])
                    {
                        return indexFromRight;
                    }
                    var temp = array[indexFromRight];
                    array[indexFromRight] = array[indexFromLeft];
                    array[indexFromLeft] = temp;
                }
                else
                {
                    return indexFromRight;
                }
            }
            return 0;
        }

    }
}
