namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            byte number = Convert.ToByte(Console.ReadLine());

            if (number == 5 || number == 10)
            {
                Console.WriteLine("The number is either exactly 5 or exactly 10");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }
        }
    }
}