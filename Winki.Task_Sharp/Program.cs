namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the deposit amount: ");
            decimal dep = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the number of months: ");
            int mon = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= mon; i++)
            {
                dep += dep * 0.07M;
            }

            Console.WriteLine($"Final deposit amount: {dep}");
        }
    }
}