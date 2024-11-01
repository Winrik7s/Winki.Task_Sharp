namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n: ");
            short n = Convert.ToInt16(Console.ReadLine());

            short a = 5;

            if (n < 10)
            {
                Console.WriteLine("Error! Enter a two-digit number.");
            }
            else
            {
                n = (short)((n / 10) + (n % 10));
                
                if(n % a == 0)
                {
                    Console.WriteLine($"The number {n} is a multiple of {a}");
                }
                else
                {
                    Console.WriteLine($"The number {n} is not a multiple of {a}");
                }
            }
        }
    }
}