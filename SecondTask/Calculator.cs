using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ArrayOutput arrayOutput = new ArrayOutput();

            var elapsedTimeFromFirstTask = firstPartOfSecondTask.GetSum(rows, columns);
            var elapsedFirstTaskTime = elapsedTimeFromFirstTask.ToString(@"mm\:ss\.FFFFFF");

            var resultSecondPartOfSecondTask = secondPartOfSecondTask.GetSum(rows, columns, direction);
            if (direction == DirectionToSum.SumByRows)
                arrayOutput.GetArrayToConsoleByRows(resultSecondPartOfSecondTask.Item1);
            else
                arrayOutput.GetArrayToConsoleByColumns(resultSecondPartOfSecondTask.Item1);
            var elapsedSceondTaskTime = resultSecondPartOfSecondTask.Item2.ToString(@"mm\:ss\.FFFFFF");

            Console.WriteLine($"Elapsed time from first task: {elapsedFirstTaskTime}");
            Console.WriteLine($"Elapsed time from second task: {elapsedSceondTaskTime}");

        }
    }
}
