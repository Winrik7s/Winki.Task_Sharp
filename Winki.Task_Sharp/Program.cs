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

            if (num1 == num2)
            {
                Console.WriteLine($"Numbers {num1} and {num2} are the same");
            }
            else
            {
                Console.WriteLine($"Numbers {num1} and {num2} are not the same");
            }

            if (num1 > num2)
            {
                Console.WriteLine("The first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The second number is greater than the first");
            }
        }
    }
}