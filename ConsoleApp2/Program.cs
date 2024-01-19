namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            for (int i = 0; i < 9; i++)
            {
                Console.Write("Bảng cửu chương của " + i);

                for (int j = 1; j <= 10; j++)
                {
                   
                    Console.WriteLine(+i + " x " + j + " = " + i * j);

                }
                Console.WriteLine();
            }
            
        }
    }
}
