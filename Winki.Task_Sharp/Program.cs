namespace Winki.Task_Sharp
{
    public class Program
    {
        static void F(int number)
        {
            if(number <= 0)
            {
                Console.WriteLine("The number is not a positive integer!");
            }
            else
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number is not prime");
                }
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Type an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            F(num);

        }
    }
}