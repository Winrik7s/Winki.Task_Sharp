namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Queen's move a: ");
            byte a = Convert.ToByte(Console.ReadLine());

            Console.Write("Queen's move b: ");
            byte b = Convert.ToByte(Console.ReadLine());

            const byte c = 1;
            const byte d = 1;

            if((a == 1 && b == 4) && (c == 1 && d == 1))
            {
                Console.WriteLine("The queen threatens the field c,d!");
            }
            else
            {
                Console.WriteLine("The queen does not threaten the pieces.");
            }
        }
    }
}