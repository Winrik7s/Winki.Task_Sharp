namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            byte num = Convert.ToByte(Console.ReadLine());

            if(num == 5 || num == 10)
            {
                Console.WriteLine("The number is equal to 5 or 10");
            }
            else
            {
                Console.WriteLine("Unknown number!");
            }
        }
    }
}