using System;

namespace SecondTask
{
    /// <summary>
    /// Calls methods to calculate values ​​from arrays
    /// </summary>
    internal class ResultOutput
    {
        /// <summary>
        /// Gets results from methods and outputs elapsed time
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="direction">How to sum, by rows or by columns</param>
        internal void GetResult(int rows, int columns, DirectionToSum direction)
        {
            Console.WriteLine("");
            Calculator calculator = new Calculator();
            ArrayOutput arrayOutput = new ArrayOutput();
            int[,] twoDimensionalArray = new int[rows, columns];
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[columns];
            }

            var resultFirstPartOfSecondTask = calculator.GetFirstPartSum(twoDimensionalArray, direction);
            if (direction == DirectionToSum.SumByRows)
                arrayOutput.GetArrayToConsoleByRows(resultFirstPartOfSecondTask.Item1);
            else
                arrayOutput.GetArrayToConsoleByColumns(resultFirstPartOfSecondTask.Item1);
            var elapsedFirstPartTime = resultFirstPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            var resultSecondPartOfSecondTask = calculator.GetSecondPartSum(jaggedArray, direction, columns, rows);
            if (direction == DirectionToSum.SumByRows)
                arrayOutput.GetJaggedArrayToConsoleByRows(resultSecondPartOfSecondTask.Item1);
            else
                arrayOutput.GetJaggedArrayToConsoleByColumns(resultSecondPartOfSecondTask.Item1);
            var elapsedSecondPartTime = resultSecondPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            Console.WriteLine("_________________________________");
            Console.WriteLine($"Elapsed time from first task: {elapsedFirstPartTime}");
            Console.WriteLine($"Elapsed time from second task: {elapsedSecondPartTime}");
            Console.WriteLine($"Elapsed time from third task: {elapsedSecondPartTime}");

        }
    }
}
