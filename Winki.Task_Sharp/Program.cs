namespace Winki.Task_Sharp
{
    public class Program
    {
        static decimal InterestOnTheDeposit(decimal sum, decimal deposit, short day)
        {
            decimal dep = sum * deposit * day;
            return dep;
        }

        static void Main(string[] args)
        {
            const short day = 120;

            Console.Write("Enter the deposit amount: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            if(sum < 100)
            {
                Console.WriteLine($"Deposit amount with accrued interest: {InterestOnTheDeposit(sum, 0.05M, day)}");
            }
            else if(sum >= 100 || sum <= 200)
            {
                Console.WriteLine($"Deposit amount with accrued interest: {InterestOnTheDeposit(sum, 0.07M, day)}");
            }
            else if(sum > 200)
            {
                Console.WriteLine($"Deposit amount with accrued interest: {InterestOnTheDeposit(sum, 0.1M, day)}");
            }
        }
    }
}