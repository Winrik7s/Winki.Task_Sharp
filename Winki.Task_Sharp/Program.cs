namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number one: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number two: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int i = number2;

            do
            {
               Console.WriteLine(Math.Sqrt(i));
               i--;
            }
            while (i >= number1);
        }
    }
}