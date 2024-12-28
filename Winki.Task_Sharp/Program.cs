namespace Winki.Task_Sharp
{
    public class Program
    {
        static void F(short x)
        {
            short num1 = (short)(x / 10);
            short num2 = (short)(x % 10);

            if(num1 == 3 || num1 == 6 || num1 == 9) 
            {
                Console.WriteLine($"В введенное число входит цифра: {num1}");
            }
            else if (num2 == 3 || num2 == 6 || num2 == 9) 
            {
                Console.WriteLine($"В введенное число входит цифра: {num2}");
            }
            else
            {
                Console.WriteLine("В введенное число не входят цифры: 3, 6, 9");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            short number = Convert.ToInt16(Console.ReadLine());

            if(number < 10 || number > 99) 
            {
                Console.WriteLine("Число должно быть двузначным!");
            }
            else
            {
                F(number);
            }
        }
    }
}