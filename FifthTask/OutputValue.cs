using System;

namespace FifthTask
{
    /// <summary>
    /// Provides functionality to get values from the user input and output result to console
    /// </summary>
    public class OutputValue
    {
        private Random _random = new Random();
        private QuickSort _quickSort = new QuickSort();
        private TreeSort _treeSort = new TreeSort();

        /// <summary>
        /// Gets values from the user input
        /// </summary>
        public void GetInputValue()
        {
            var appIsRunning = true;
            while (appIsRunning)
            {
                Console.Write("Size of one-dimensional array: ");
                var resultOfParsing = int.TryParse(Console.ReadLine(), out var size);
                if (!resultOfParsing || (size <= 0))
                {
                    GetErrorMessage();
                    continue;
                }
                Console.WriteLine("");
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = _random.Next(1, 101);
                    Console.Write($"{array[i]} ");
                }
                GetOutputValue(array);

                Console.WriteLine($"______________________________________");
                Console.WriteLine("Press 'N/n' if you want to exit, otherwise the application will restart");
                var answer = Console.ReadLine();

                if (string.Equals(answer, "n", StringComparison.InvariantCultureIgnoreCase))
                {
                    appIsRunning = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }

        /// <summary>
        /// Writes results of sorting to the console
        /// </summary>
        /// <param name="array">One dimensional array with random numbers</param>
        private void GetOutputValue (int [] array)
        {
            var size = array.Length;
            var quickSortTime = _quickSort.GetStartQuickSort(array, 0, size - 1);
            Console.WriteLine($"\n______________________________________");
            Console.WriteLine("\nSorted Array by Quick sort: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("");
            var elapsedQuickSortTime = quickSortTime.ToString(@"mm\:ss\.FFFFFF");
            Console.WriteLine($"\nQuick Sort Time: {elapsedQuickSortTime}");

            Console.WriteLine($"______________________________________");
            var treeSortTime = _treeSort.GetStartTreeSort(array);
            Console.WriteLine("");
            Console.WriteLine("Sorted Array by Tree sort: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("");
            var elapsedTreeSortTime = treeSortTime.ToString(@"mm\:ss\.FFFFFF");
            Console.WriteLine($"\nTree Sort Time: {elapsedTreeSortTime}");
        }

        /// <summary>
        /// Writes an error message, if value was wrong
        /// </summary>
        private void GetErrorMessage()
        {
            Console.WriteLine("Looks like wrong value, try again");
            Console.WriteLine("_________________________________");
        }
    }

}

