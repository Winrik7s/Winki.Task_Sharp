namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            short year;
            short month;

            short yearH;
            short monthH;

            short result;

            Console.Write("Enter your year of birth: ");
            yearH = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter your month of birth: ");
            monthH = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter current year: ");
            year = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter current month: ");
            month = Convert.ToInt16(Console.ReadLine());

            result = (short)(year - yearH);

            if(month == monthH)
            {
                Console.WriteLine($"You're {result} years old!");
            }
            else
            {
                Console.WriteLine($"You're {result} years and {month - monthH} month old!");
            }

        }
    }
}
