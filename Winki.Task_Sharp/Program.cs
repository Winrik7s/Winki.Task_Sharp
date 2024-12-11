namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            short[] arr = new short[5];
            Console.WriteLine("Enter the array elements:\n");

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}