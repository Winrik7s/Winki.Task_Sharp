namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a three-digit number: ");
            short number = short.Parse(Console.ReadLine());

            short num1 = (short)(number / 100);
            short num2 = (short)((number / 10) % 10);
            short num3 = (short)(number % 10);

            short nSqr = (short)(number * number);
            short sum = (short)((num1 * num1 * num1) + (num2 * num2 * num2) + (num3 * num3 * num3));


        }
    }
}