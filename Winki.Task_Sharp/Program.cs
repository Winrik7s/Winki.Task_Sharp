namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            //Вариант А:
            int lastNum = number % 10;

            if(lastNum % 2 == 0) 
            {
                Console.WriteLine($"Last digit of {number} is even");
            }
            else
            {
                Console.WriteLine($"Last digit of {number} is not even");
            }

            Console.WriteLine();

            //Вариант Б:
            if (lastNum % 2 != 0)
            {
                Console.WriteLine($"Last digit of is not even");
            }
            else
            {
                Console.WriteLine($"Last digit of is even");
            }
        }
    }
}