using FirstTask1_1;

namespace FirstTask1_1
{
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
                    int firstToBorder = 0;
                    int firstToCenter = rows * columns - 1;
                    starter.GetStartToCenter(rows, columns, firstToBorder, array);
                    starter.GetStartToBorder(rows, columns, firstToCenter, array);
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}