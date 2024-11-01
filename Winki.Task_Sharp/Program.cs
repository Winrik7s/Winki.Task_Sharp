namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Foo(ref short x, out short result)
        {
            short x1 = (short)((x / 100));
            short x2 = (short)(((x / 10) % 10));
            short x3 = (short)(((x % 100) % 10));

            result = (short)((x3 * 100) + (x2 * 10) + (x1));

            if(result == x)
            {
                Console.WriteLine($"The number {result} is a polyndrome!");
            }
            else
            {
                Console.WriteLine($"The number {result} is not a polyndrome!");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("");
        }
    }
}