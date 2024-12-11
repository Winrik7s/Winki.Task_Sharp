namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            short[] arr = new short[5];
            Console.WriteLine("Enter the array elements:\n");

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Enter number: ");
            short n = Convert.ToInt16(Console.ReadLine());

            for(int k = 0; k < arr.Length; k++)
            {
                sum += arr[k];
            }

            if(sum < n)
            {
                Console.WriteLine($"The sum of the elements: {sum} is less than the number: {n}");
            }
            else
            {
                Console.WriteLine($"The sum of the elements: {sum} is greater than the number: {n}");
            }
        }
    }
}