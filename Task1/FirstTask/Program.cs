using FirstTask1_1;
using System;

namespace FirstTask1_1
{
    interface IMy
    {
        void DoWork();
    }

    class My : IMy
    {
        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public void DoWork2()
        {
            throw new NotImplementedException();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var my1 = new My();
            IMy my2 = new My();

            Starter starter = new Starter();
            // TODO: Here a problem. What if we want to end the program?
            while (true)
            {
                //bool success;
                try
                {
                    Console.WriteLine("Write rows number");

                    // TODO: Good style
                    //success = int.TryParse(Console.ReadLine(), out var rows);
                    //if (!success)
                    //{
                    //    continue;
                    //}

                    var rows = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write columns number");
                    int columns = Int32.Parse(Console.ReadLine());
                    var array = new int[rows, columns];
                    int firstToBorder = 0;
                    int firstToCenter = rows * columns - 1;
                    starter.GetStartToCenter(rows, columns, firstToBorder, array);
                    // TODO: Create clear method for array
                    starter.GetStartToBorder(rows, columns, firstToCenter, array);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Error");
                }
            }

            //////////////////////////////////////////////////////////
            // TODO: example how it could looks like.
            //var continueExecution = true;

            //do
            //{
            //    Console.WriteLine("Do you want to continue? Y/N (y/n)");
            //    var answer = Console.ReadLine();
            //    if (!string.IsNullOrWhiteSpace(answer) && answer.Equals("n", StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        continueExecution = false;
            //    }

            //} while (continueExecution);
        }
    }
}