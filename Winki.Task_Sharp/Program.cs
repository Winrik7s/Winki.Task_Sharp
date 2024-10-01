namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("King's move a: ");
            byte a = Convert.ToByte(Console.ReadLine());

            Console.Write("King's move b: ");
            byte b = Convert.ToByte(Console.ReadLine());

            const byte c = 6;
            const byte d = 2;

            if(a == 4 && b == 2 || a == 5 && b == 2 || a == 6 && b == 2)
            {
                Console.WriteLine("The king has successfully made a move!");
            }
            else
            {
                Console.WriteLine("The king cannot make a move to the specified field.");
            }
        }
    }
}