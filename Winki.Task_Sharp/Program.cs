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
            
        }
    }
}