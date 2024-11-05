namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            short count = 0;
            Console.Write("Select the language of the letters(r - Ru, e - En): ");

            string? ch = Console.ReadLine().ToLower();

            if (ch == "e")
            {
                Console.Write("Enter a string: ");
                string? line = Console.ReadLine();

                char[] Ensymbol = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Y', 'y' };

                for (int i = 0; i < line?.Length; i++)
                {
                    for (int j = 0; j < Ensymbol.Length; j++)
                    {
                        if (Ensymbol[j] == line[i])
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine($"The number of vowel letters in the string {line} equals: {count}");
            }
            else if (ch == "r")
            {
                Console.Write("Введите строку: ");
                string? line = Console.ReadLine();

                char[] Rusymbol = { 'А', 'а', 'У', 'у', 'О', 'о', 'И', 'и', 'Э', 'Ы', 'ы', 'Я', 'я', 'Ю', 'ю', 'Е', 'е', 'Ё', 'ё', 'э' };

                for (int i = 0; i < line?.Length; i++)
                {
                    for (int j = 0; j < Rusymbol.Length; j++)
                    {
                        if (Rusymbol[j] == line[i])
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine($"Кол - во гласных в строке {line} равняется: {count}");
            }
            else
            {
                Console.WriteLine("Error! Enter (r - Ru, e - En)");
            }
        }
    }
}