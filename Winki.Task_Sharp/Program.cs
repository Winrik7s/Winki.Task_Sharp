namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = i; j <= 10; j++)
                {
                    Console.WriteLine($"{i * j}\t");
                }

                Console.WriteLine();
            }
        }
    }
}