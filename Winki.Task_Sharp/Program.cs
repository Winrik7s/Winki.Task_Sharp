namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (number1 % number2 == 0)
            {
                Console.WriteLine($"{number2} is the divisor of {number1}");
            }
            else
            {
                Console.WriteLine($"{number2} is not the divisor of {number1}");
            }

            Console.WriteLine();

            if (number2 % number1 == 0)
            {
                Console.WriteLine($"{number1} is the divisor of {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is not the divisor of {number2}");
            }
        }
    }
}