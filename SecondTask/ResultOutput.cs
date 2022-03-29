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
        /// <param name="operationOnNumbers">Which one operation has to use, sum or subtract</param>
        /// <param name="sizeOfSquare"></param>
        internal void GetResult(int rows, int columns, DirectionToSum direction, OperationOnNumbers operationOnNumbers, int sizeOfSquare)
        {
            Console.WriteLine("");
            Filling filling = new Filling();
            ArrayOutput arrayOutput = new ArrayOutput();
            int[,] twoDimensionalArray = new int[rows, columns];
            int[,] squareArray = new int[sizeOfSquare, sizeOfSquare];
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[columns];
            }

            var resultFirstPartOfSecondTask = filling.GetFirstPartSum(twoDimensionalArray, direction);
            if (direction == DirectionToSum.SumByRows)
                arrayOutput.GetArrayToConsoleByRows(resultFirstPartOfSecondTask.Item1);
            else
                arrayOutput.GetArrayToConsoleByColumns(resultFirstPartOfSecondTask.Item1);
            var elapsedFirstPartTime = resultFirstPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            var resultSecondPartOfSecondTask = filling.GetSecondPartSum(jaggedArray, direction, columns, rows);
            if (direction == DirectionToSum.SumByRows)
                arrayOutput.GetJaggedArrayToConsoleByRows(resultSecondPartOfSecondTask.Item1);
            else
                arrayOutput.GetJaggedArrayToConsoleByColumns(resultSecondPartOfSecondTask.Item1);
            var elapsedSecondPartTime = resultSecondPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            var resultThirdPartOfSecondTask = filling.GetThirdPartSum(squareArray, operationOnNumbers);
            arrayOutput.GetArrayToConsoleByColumns(resultThirdPartOfSecondTask.Item1);
            var elapsedThirdPartTime = resultThirdPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            Console.WriteLine("_________________________________");
            Console.WriteLine($"Elapsed time from first task: {elapsedFirstPartTime}");
            Console.WriteLine($"Elapsed time from second task: {elapsedSecondPartTime}");
            Console.WriteLine($"Elapsed time from third task: {elapsedThirdPartTime}");

        }
    }
}
