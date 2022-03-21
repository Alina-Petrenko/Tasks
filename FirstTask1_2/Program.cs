using FirstTask1_2;

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
                    
                    Console.WriteLine("Set flag: 1 - To Center, 2 - To Border");
                    int flag = Int32.Parse(Console.ReadLine());                       
                    
                    Console.WriteLine("Write first number");
                    int first = Int32.Parse(Console.ReadLine());
                    starter.GetStart(rows, columns, first, array, flag);
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}