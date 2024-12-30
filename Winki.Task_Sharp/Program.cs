namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number <= 0)
            {
                Console.WriteLine("The number must not be less than or equal to 0!");
            }
            else
            {
                int i = 10;

                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i <= number);
            }
        }
    }
}