using System;

namespace FourthTask
{
    /// <summary>
    /// Provides a mechanism for getting values from the user
    /// </summary>
    internal class InputValue
    {
        private OutputResult _outputResult = new OutputResult();
        private Filling _filling = new Filling();

        /// <summary>
        /// Gets values from user
        /// </summary>
        public void GetInputedValue()
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

                Console.Write("Rows of two-dimensional array: ");
                resultOfParsing = int.TryParse(Console.ReadLine(), out var rows);
                if (!resultOfParsing || (rows <= 0))
                {
                    GetErrorMessage();
                    continue;
                }

                Console.Write("Columns of two-dimensional array: ");
                resultOfParsing = int.TryParse(Console.ReadLine(), out var columns);
                if (!resultOfParsing || (columns <= 0))
                {
                    GetErrorMessage();
                    continue;
                }

                Console.WriteLine("");
                Console.WriteLine("Decimal One Dimensional Array");
                decimal[] decimalOneDimensionalArray = _filling.GetRandomDecimalOneDimensionalArray(size);

                Console.WriteLine("Char One Dimensional Array");
                char[] charOneDimensionalArray = _filling.GetRandomCharOneDimensionalArray(size);

                Console.WriteLine("Decimal Two Dimensional Arra");
                decimal[,] decimalTwoDimensionalArray = _filling.GetRandomDecimalTwoDimensionalArray(rows, columns);

                Console.WriteLine("Char Two Dimensional Array");
                char[,] charTwoDimensionalArray = _filling.GetRandomCharTwoDimensionalArray(rows, columns);
                Console.WriteLine("___________________________________");

                Console.Write("Searched decimal value: ");
                resultOfParsing = decimal.TryParse(Console.ReadLine(), out var searchedDecimalValue);
                if (!resultOfParsing)
                {
                    GetErrorMessage();
                    continue;
                }

                Console.WriteLine("");
                Console.Write("Searched char value: ");
                resultOfParsing = char.TryParse(Console.ReadLine(), out var searchedCharValue);
                if (!resultOfParsing)
                {
                    GetErrorMessage();
                    continue;
                }
                Console.WriteLine("");

                _outputResult.GetDecimalResultToConsole(decimalOneDimensionalArray, decimalTwoDimensionalArray, searchedDecimalValue);
                _outputResult.GetCharResultToConsole(charOneDimensionalArray,charTwoDimensionalArray,searchedCharValue);

                Console.WriteLine("______________________________________");
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
        /// Writes an error message, if value was wrong
        /// </summary>
        /// 
        private void GetErrorMessage()
        {
            Console.WriteLine("Looks like wrong value, try again");
            Console.WriteLine("_________________________________");
        }
    }
}
    