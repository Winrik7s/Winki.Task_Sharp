namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter the second number: ");
            float num2 = Convert.ToSingle(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("The two numbers are equal");
            }
            else if(num1 > num2)
            {
                Console.WriteLine("The first number is greater than the second");
            }
            else if(num1 < num2)
            {
                Console.WriteLine("The first number is less than the second");
            }
        }
    }
}