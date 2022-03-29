using System;

namespace SecondTask
{
    // TODO: Better to create separate file Enums.cs to store enums
    enum DirectionToSum
    {
        SumByRows = 1,
        SumByColums = 2
    }
    enum OperationOnNumbers
    {
        Sum = 1,
        Subtraction = 2
    }
    /// <summary>
    /// Starts the project
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// TODO: "Entry point into application"
        /// Starts the projects, gets values from user
        /// </summary>
        /// TODO: parameter could be removed. Main will work without it.
        /// <param name="_"></param>
        static void Main(string[] _)
        {
            var calculator = new ResultOutput();
            var appIsRunning = true;
            while (appIsRunning)
            {
                Console.Write("Columns: ");
                // TODO: if we enter negative number, we will receive OverflowException.
                // TODO: if we enter zero, we will receive IndexOutOfRangeException for jagged array
                var resultOfParsing = int.TryParse(Console.ReadLine(), out var columns);
                if (!resultOfParsing)
                {
                    Program.GetErrorMessage();
                    continue;
                }
                Console.Write("Rows: ");
                resultOfParsing = int.TryParse(Console.ReadLine(), out var rows);
                if (!resultOfParsing)
                {
                    Program.GetErrorMessage();
                    continue;
                }
                Console.Write("Sum by Rows = 1, Sum by columns = 2: ");
                // TODO: "inputDirection"
                var inputedDirection = Console.ReadLine();
                resultOfParsing = int.TryParse(inputedDirection, out var value);
                if (!resultOfParsing)
                {
                    Program.GetErrorMessage();
                    continue;
                }

                // TODO: why do we need new variable? Why we cannot use "resultOfParsing"?
                var success = true;
                // TODO: why do we need this foreach?
                foreach (int i in Enum.GetValues(typeof(DirectionToSum)))
                {
                    // TODO: == false, == true is redundant in conditions.
                    // TODO: if (!Enum.IsDefined(typeof(DirectionToSum), value))
                    if (Enum.IsDefined(typeof(DirectionToSum), value) == false)
                    {
                        Program.GetErrorMessage();
                        success = false;
                        break;
                    }
                }
                if (success == false)
                {
                    continue;
                }
                DirectionToSum direction = (DirectionToSum)Enum.Parse(typeof(DirectionToSum), inputedDirection);

                Console.Write("Size of square: ");
                resultOfParsing = int.TryParse(Console.ReadLine(), out var sizeOfSquare);
                if (!resultOfParsing)
                {
                    Program.GetErrorMessage();
                    continue;
                }
                Console.Write("Sum Diagonals values = 1, Subtract Diagonals values = 2: ");
                var inputedOperation = Console.ReadLine();
                resultOfParsing = int.TryParse(inputedOperation, out var operation);
                if (!resultOfParsing)
                {
                    Program.GetErrorMessage();
                    continue;
                }
                // TODO: same as previous questions about enums
                foreach (int i in Enum.GetValues(typeof(OperationOnNumbers)))
                {
                    if (Enum.IsDefined(typeof(OperationOnNumbers), operation) == false)
                    {
                        Program.GetErrorMessage();
                        success = false;
                        break;
                    }
                }
                if (success == false)
                {
                    continue;
                }
                OperationOnNumbers operationOnNumbers = (OperationOnNumbers)Enum.Parse(typeof(OperationOnNumbers), inputedOperation);

                calculator.GetResult(rows, columns, direction, operationOnNumbers, sizeOfSquare);

                Console.WriteLine("Press 'N/n' if you want to exit, otherwise the application will restart");
                var answer = Console.ReadLine();
                // TODO: for strings is good practice to compare them using string.Equals(), because it contains overloads to specify how we want to compare
                // TODO: if (string.Equals(answer, "n", StringComparison.InvariantCultureIgnoreCase))
                // TODO: Read more about StringComparison enum
                if (answer.ToLower() == "n")
                {
                    appIsRunning = false;
                }
                else
                // TODO: if we use braces after "if" statement then better to use after "else"
                    Console.Clear();
            }
        }
        /// <summary>
        /// Writes an error message, if value was wrong
        /// </summary>
        private static void GetErrorMessage ()
        {
            Console.WriteLine("Looks like wrong value, try again");
            Console.WriteLine("_________________________________");
        }
    }
}
