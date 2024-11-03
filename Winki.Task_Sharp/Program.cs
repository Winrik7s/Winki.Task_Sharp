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
                short sum = (short)((number / 100) + (number / 10 % 10) + (number % 10));

                if (sum % 5 == 0)
                {
                    Console.WriteLine($"The sum of digits of {number} is a multiple 5");
                }
                else
                {
                    Console.WriteLine($"The sum of digits of {number} is not a multiple 5");
                }
            }
        }
    }
}