namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            short a = Convert.ToInt16(Console.ReadLine());

            short num1 = (short)(a / 10);
            short num2 = (short)(a % 10);

            if (num1 > num2)
            {
                Console.WriteLine($"");
            }
            else
            {
                Console.WriteLine($"");
            }

            if (num1 == num2)
            {
                Console.WriteLine($"");
            }
            else
            {
                Console.WriteLine($"");
            }

        }
    }
}