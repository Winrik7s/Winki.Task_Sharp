namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n: ");
            short n = Convert.ToInt16(Console.ReadLine());

            if (n < 10)
            {
                Console.WriteLine("Error! Enter a two-digit number.");
            }
            else
            {
                n = (short)((n / 10) + (n % 10));
                
                if(n % 3 == 0)
                {
                    Console.WriteLine($"The number {n} is a multiple of 3");
                }
                else
                {
                    Console.WriteLine($"The number {n} is not a multiple of 3");
                }
            }
        }
    }
}