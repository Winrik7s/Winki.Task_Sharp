namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float number = Convert.ToSingle(Console.ReadLine());

            if(number > 5 && number < 10)
            {
                Console.WriteLine("A number greater than 5 and less than 10");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }
        }
    }
}