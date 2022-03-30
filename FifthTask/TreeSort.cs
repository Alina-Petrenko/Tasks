using System;
using System.Diagnostics;

namespace FifthTask
{
    /// <summary>
    /// Provides a mechanism for Tree Sort array 
    /// </summary>
    public class TreeSort
    {
        private TimeSpan _timeSpan = new TimeSpan();
        private Stopwatch _stopwatch = new Stopwatch();

        /// <summary>
        /// Sorts <paramref name="array"/>, adds <paramref name="array"/> values ​​to methods for sorting 
        /// </summary>
        /// <param name="array">One-dimensional array with random numbers</param>
        /// <returns>Returns spent time for calculations</returns>
        public TimeSpan GetStartTreeSort(int[] array)
        {
            _stopwatch.Start();
            var treeNode = new Node(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Add(new Node(array[i]));
            }
            treeNode.Traverse();
            _stopwatch.Stop();
            _timeSpan = _stopwatch.Elapsed;
            return _timeSpan;
        }
    }
}
