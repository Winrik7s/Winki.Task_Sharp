namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the deposit amount: ");

            float percent;
            float amount = Convert.ToSingle(Console.ReadLine());

            if (amount < 100)
            {
                percent = (float)(amount * 0.05);
            }
            else if(amount >= 100)
            {
                percent = (float)(amount * 0.07);
            }
            else
            {
                percent = (float)(amount * 0.1);
            }

            Console.WriteLine($"Investment amount with interest: {percent + amount}");
        }
    }
}