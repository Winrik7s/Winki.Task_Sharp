namespace Winki.Task_Sharp
{
    public class Program
    {
        static void F(short x)
        {
            short num1 = (short)(x / 10);
            short num2 = (short)(x % 10);

            if(num1 == 4 || num1 == 7) 
            {
                Console.WriteLine($"В введенное число входит цифра: {num1}");
            }
            else if (num2 == 4 || num2 == 7) 
            {
                Console.WriteLine($"В введенное число входит цифра: {num2}");
            }
            else
            {
                Console.WriteLine("В введенное число не входят цифры: 4, 7");
            }
        }

        static void Main(string[] args)
        {

        }
    }
}