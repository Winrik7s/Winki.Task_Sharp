namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the lower left corner of the first rectangle (x1, y1):");

            short x1 = Convert.ToInt16(Console.ReadLine());
            short y1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the width and height of the first rectangle:");

            float w1 = Convert.ToSingle(Console.ReadLine());
            float h1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the lower left corner of the second rectangle (x1, y1):");

            short x2 = Convert.ToInt16(Console.ReadLine());
            short y2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the width and height of the second rectangle:");

            float w2 = Convert.ToSingle(Console.ReadLine());
            float h2 = Convert.ToSingle(Console.ReadLine());

            float x1Max = x1 + w1;
            float y1Max = y1 + h1;

            float x2Max = x2 + w2;
            float y2Max = y2 + h2;

            float minX = Math.Min(x1, x2);
            float minY = Math.Min(y1, y2);

            float maxX = Math.Max(x1Max, x2Max);
            float maxY = Math.Max(y1Max, y2Max);

            Console.WriteLine($"Bottom left corner: {minX}, {minY}");
            Console.WriteLine($"Upper right corner: {maxX}, {maxY}");
        }
    }
}