using System;

namespace SecondTask
{
    /// <summary>
    /// Calls methods to calculate values ​​from arrays
    /// </summary>
    internal class Calculator
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
            FirstPartOfSecondTask firstPartOfSecondTask = new FirstPartOfSecondTask();
            SecondPartOfSecondTask secondPartOfSecondTask = new SecondPartOfSecondTask();
            ThirdPartOfSecondTask thirdPartOfSecondTask = new ThirdPartOfSecondTask();
            int[,] twoDimensionalArray = new int[rows, columns];
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[columns];
            }
            ArrayOutput arrayOutput = new ArrayOutput();

            var elapsedTimeFromFirstTask = firstPartOfSecondTask.GetSum(twoDimensionalArray);
            var elapsedFirstTPartTime = elapsedTimeFromFirstTask.ToString(@"mm\:ss\.FFFFFF");

            var resultSecondPartOfSecondTask = secondPartOfSecondTask.GetSum(twoDimensionalArray, direction);
            if (direction == DirectionToSum.SumByRows)
                arrayOutput.GetArrayToConsoleByColumns(resultSecondPartOfSecondTask.Item1);
            else
                arrayOutput.GetArrayToConsoleByRows(resultSecondPartOfSecondTask.Item1);
            var elapsedSecondPartTime = resultSecondPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            var resultThirdPartOfSecondTask = thirdPartOfSecondTask.GetSum(jaggedArray, direction, columns, rows);
            if (direction == DirectionToSum.SumByRows)
                arrayOutput.GetJaggedArrayToConsoleByRows(resultThirdPartOfSecondTask.Item1);
            else
                arrayOutput.GetJaggedArrayToConsoleByColumns(resultThirdPartOfSecondTask.Item1);
            var elapsedThirdPartTime = resultThirdPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            Console.WriteLine($"Elapsed time from first task: {elapsedFirstTPartTime}");
            Console.WriteLine($"Elapsed time from second task: {elapsedSecondPartTime}");
            Console.WriteLine($"Elapsed time from third task: {elapsedThirdPartTime}");

        }
    }
}
