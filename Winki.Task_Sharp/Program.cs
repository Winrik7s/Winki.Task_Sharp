namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            while (true)
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{num1 * num2}");
                }
            }
        }
    }
}