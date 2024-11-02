namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a three-digit number: ");

            //Parse method is faster than Convert method
            short number = Int16.Parse(Console.ReadLine());

            short num1 = (short)(number / 100);
            short num2 = (short)((number / 10) % 10);
            short num3 = (short)(number % 10);

            if(number < 100 || number > 999)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"The number {num1} is greater than {num3}");
                }
                else
                {
                    Console.WriteLine($"The number {num3} is greater than {num1}");
                }

                if(num1 > num2)
                {
                    Console.WriteLine($"The number {num1} is greater than {num2}");
                }
                else
                {
                    Console.WriteLine($"The number {num2} is greater than {num1}");
                }

                if (num2 > num3)
                {
                    Console.WriteLine($"The number {num2} is greater than {num3}");
                }
                else
                {
                    Console.WriteLine($"The number {num3} is greater than {num2}");
                }
            }
        }
    }
}