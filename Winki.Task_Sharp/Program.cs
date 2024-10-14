namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter m: ");
            short m = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter n: ");
            short n = Convert.ToInt16(Console.ReadLine());

            if (m % n == 0) 
            {
                short result = (short)(m / n);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Indivisible!");
            }
        }
    }
}