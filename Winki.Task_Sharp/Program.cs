namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] symbol = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Y', 'y'};

            short count = 0;

            Console.Write("Enter a string: ");
            string? line = Console.ReadLine();

            for (int i = 0; i < line?.Length; i++)
            {
                for(int j = 0; j < symbol.Length; j++)
                {
                    if (symbol[i] == line[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"The number of vowel letters in the string {line} equals: {count}");
        }
    }
}