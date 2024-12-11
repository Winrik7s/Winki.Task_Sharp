namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            const float N = (float)100.78;
            float[] arr = { 23.4f, 1.5f, -79.54f, 21.2f, 7.12f, 11.45f, 54.15f, 0.2f, 9.78f, 2.9f};

            float sum = 0f;

            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            if(sum > N)
            {
                Console.WriteLine($"The sum of the elements {sum} is greater than the number {N}");
            }
            else
            {
                Console.WriteLine($"The sum of the elements {sum} is less than the number {N}");
            }
        }
    }
}