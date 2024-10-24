namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Cube(ref short x, out short result)
        {
            result = x;

            short number1 = (short)(x / 10);
            short number2 = (short)(x % 10);

            short cub = (short)((short)((number1 * number1 * number1) + (number2 * number2 * number2)) * 4);
            short sqr = (short)(x * x);

            if (cub == sqr)
            {
                Console.WriteLine($"For the number {result} - positive!");
            }
            else
            {
                Console.WriteLine($"For the number {result} - negative!");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            short number = Convert.ToInt16(Console.ReadLine());

            Cube(ref number, out short resultNum);
        }
    }
}