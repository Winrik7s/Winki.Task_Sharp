namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a three-digit number: ");
            short number = Convert.ToInt16(Console.ReadLine());

            if(number < 100 || number > 999)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                short sum = (short)((number / 100) * (number / 10 % 10) * (number % 10));

                if (sum >= number)
                {
                    Console.WriteLine($"The product of the digits ({sum}) is greater than the number {number}");
                }
                else
                {
                    Console.WriteLine($"The product of the digits ({sum}) is less than the number {number}");
                }
            }
        }
    }
}