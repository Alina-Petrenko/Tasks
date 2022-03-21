using FirstTask1_2;
using System.Diagnostics;

namespace FirstTask1_2
{
    enum Flag
    {
        ToCenter = 1,
        ToBorder
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Starter starter = new Starter();
            while (true)
            {
                try
                {
                    Console.WriteLine("Write rows number");
                    int rows = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Write columns number");
                    int columns = Int32.Parse(Console.ReadLine());
                    int[,] array = new int[rows, columns];

                    Console.WriteLine("Write first number");
                    int firstValue = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Write increment number");
                    int increment = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Set flag: 1 - To Center, 2 - To Border");
                    int flag = Int32.Parse(Console.ReadLine());

                    string elapsedTime = starter.GetStart(rows, columns, firstValue, array, flag, increment);
                    Console.WriteLine($"Elapsed time: {elapsedTime}\n");
                }
                catch
                {
                    Console.WriteLine("Oops! It's seems like you wrote incorrect value! Try again");
                }               
            }
        }
    }
}