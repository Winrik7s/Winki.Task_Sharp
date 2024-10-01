namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bishop move a: ");
            byte a = Convert.ToByte(Console.ReadLine());

            Console.Write("Bishop move b: ");
            byte b = Convert.ToByte(Console.ReadLine());

            const byte c = 6;
            const byte d = 2;

            if((a == 6 && b == 4) && (c == 6 && d == 2))
            {
                Console.WriteLine("The bishop threatens the field c,d!");
            }
            else
            {
                Console.WriteLine("The elephant doesn't threaten the fields.");
            }
        }
    }
}