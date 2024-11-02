namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a three-digit number: ");
            short number = short.Parse(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                short num1 = (short)(number / 100);
                short num2 = (short)((number / 10) % 10);
                short num3 = (short)(number % 10);

                short nSqr = (short)(number * number);
                short sum = (short)((num1 * num1 * num1) + (num2 * num2 * num2) + (num3 * num3 * num3));

                if (nSqr >= sum)
                {
                    Console.WriteLine($"The square ({nSqr}) is greater than the sum of the cubes");
                }
                else
                {
                    Console.WriteLine($"The sum of the cubes ({sum}) is greater than the square of the number");
                }
            }
        }
    }
}