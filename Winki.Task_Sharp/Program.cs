namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three-digit number: ");
            short number = Int16.Parse(Console.ReadLine());

            short num1 = (short)(number / 100);
            short num2 = (short)((number / 10) % 10);
            short num3 = (short)(number % 10);
        }
    }
}