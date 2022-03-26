using System;

namespace SecondTask
{
    enum DirectionToSum
    {
        SumByRows = 1,
        SumByColums = 2
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
            Calculator calculator = new Calculator();
            bool appIsRunning = true;
            while (appIsRunning)
            {
                Console.Write("Columns: ");
                var resultOfParsing = int.TryParse(Console.ReadLine(), out var columns);
                if (!resultOfParsing)
                {
                    Console.WriteLine("Looks like wrong value, try again");
                    continue;
                }
                Console.Write("Rows: ");
                resultOfParsing = int.TryParse(Console.ReadLine(), out var rows);
                if (!resultOfParsing)
                {
                    Console.WriteLine("Looks like wrong value, try again");
                    continue;
                }
                Console.Write("Sum by Rows = 1, Sum by columns = 2: ");
                var inputedDirection = Console.ReadLine();
                resultOfParsing = int.TryParse(inputedDirection, out var value);
                if (!resultOfParsing)
                {
                    Console.WriteLine("Looks like wrong value, try again");
                    break;
                }
                var success = true;
                foreach (int i in Enum.GetValues(typeof(DirectionToSum)))
                {
                    success = Enum.IsDefined(typeof(DirectionToSum), value);
                    if (success == false)
                    {
                        Console.WriteLine("Looks like wrong value, try again");
                        break;
                    }
                }
                //if (success == false)
                //{
                //    break;
                //}
                DirectionToSum direction = (DirectionToSum)Enum.Parse(typeof(DirectionToSum), inputedDirection);
                calculator.GetResult(rows,columns,direction);

                Console.WriteLine("Press 'N/n' if you want to exit, otherwise the application will restart");
                var answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    appIsRunning = false;
                }
                Console.WriteLine("_________________________________");
            }
        }
    }
}
