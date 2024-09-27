namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            short x11 = 4;
            short y11 = 2;

            short x12 = 3;
            short y12 = 4;

            short x21 = 3;
            short y21 = 1;

            short x22 = 5;
            short y22 = 3;

            short minX = Math.Min(x11, x21);
            short minY = Math.Min(y11, y21);
            short maxX = Math.Max(x12, x22);
            short maxY = Math.Max(y12, y22);

            Console.WriteLine($"Coordinates of the lower left corner: {minX}, {minY}");

            Console.WriteLine();

            Console.WriteLine($"Coordinates of the upper right corner: {maxX}, {maxY}");
        }
    }
}
