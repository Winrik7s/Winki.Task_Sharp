namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Foo(ref short x, out short result)
        {
            short number1 = (short)(x / 10);
            short number2 = (short)(x % 10);

            result = (short)(number1 + number2);

            if(result > 10)
            {
                Console.WriteLine($"The number {result} is two - digit!");

                if(result >= x)
                {
                    Console.WriteLine($"The number {result} is greater than the number {x}");
                }
                else
                {
                    Console.WriteLine($"The number {result} is less than the number {x}");
                }
            }
            else
            {
                Console.WriteLine($"The number {result} is not two - digit!");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            short number = Convert.ToInt16(Console.ReadLine());

            if(number <= 0 || number >= 100)
            {
                Console.WriteLine("Enter a two - digit number!");
            }
            else
            {
                Foo(ref number, out short result);
            }
        }
    }
}