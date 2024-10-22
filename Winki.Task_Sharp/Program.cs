namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            short a = Convert.ToInt16(Console.ReadLine());

            bool resultE = a % 2 == 0 ? true : false;
            bool resultS = a % 10 == 7 ? true : false;

            Console.WriteLine($"Is number {a} even or odd? {resultE}");
            Console.WriteLine($"Does the number {a} end with the number 7? {resultS}");
        }
    }
}