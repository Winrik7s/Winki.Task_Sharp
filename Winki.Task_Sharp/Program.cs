namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            float number1, number2;

            float mul;

            while(true)
            {
                Console.Write("Enter the first number: ");
                number1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Enter the second number: ");
                number2 = Convert.ToSingle(Console.ReadLine());

                if (number1 < 0 || number1 > 10 || number2 < 0 || number2 > 10)
                {
                    Console.WriteLine("Invalid values!");
                }
                else
                {
                    mul = (float)(number1 * number2);
                    Console.WriteLine($"Multiplication: {mul}");
                    break;
                }
            }
        }
    }
}