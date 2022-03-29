using System;

namespace SecondTask
{
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
        /// Starts the projects, gets values from user
        /// </summary>
        /// <param name="_"></param>
        static void Main(string[] _)
        {
            var calculator = new ResultOutput();
            var appIsRunning = true;
            while (appIsRunning)
            {
                Console.Write("Columns: ");
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
                var inputedDirection = Console.ReadLine();
                resultOfParsing = int.TryParse(inputedDirection, out var value);
                if (!resultOfParsing)
                {
                    Program.GetErrorMessage();
                    continue;
                }

                var success = true;
                foreach (int i in Enum.GetValues(typeof(DirectionToSum)))
                {
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
                if (answer.ToLower() == "n")
                {
                    appIsRunning = false;
                }
                else
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
