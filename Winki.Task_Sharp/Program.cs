namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter b: ");
            short b = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter a: ");
            short a = Convert.ToInt16(Console.ReadLine());

            if (b % a == 0) 
            {
                short result = (short)(b / a);
                Console.WriteLine($"A is a divisor of B: {result}");
            }
            else
            {
                Console.WriteLine("Indivisible!");
            }
        }
    }
}