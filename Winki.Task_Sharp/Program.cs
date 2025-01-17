namespace Winki.Task_Sharp
{
    public class Program
    {
        static decimal InterestOnTheDeposit(decimal sum, short deposit, short day)
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
                Console.WriteLine($"Deposit amount with accrued interest: {InterestOnTheDeposit(sum, 5, day)}");
            }
            else if(sum >= 100 || sum <= 200)
            {
                Console.WriteLine($"Deposit amount with accrued interest: {InterestOnTheDeposit(sum, 7, day)}");
            }
            else if(sum > 200)
            {
                Console.WriteLine($"Deposit amount with accrued interest: {InterestOnTheDeposit(sum, 10, day)}");
            }
        }
    }
}