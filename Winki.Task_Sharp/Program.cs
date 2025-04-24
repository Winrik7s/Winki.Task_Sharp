namespace Winki.Task_Sharp
{
    public class Program
    {
        static decimal Amount(decimal deposit, short month)
        {
            for(int i = 1; i <= month; i++)
            {
                deposit += deposit * 0.07M;
            }

            return deposit;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the deposit amount: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter number of months: ");
            short month = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Final deposit amount: {Amount(deposit, month)}");
        }
    }
}