namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            float r;
            float a;

            float h;

            float A;
            float S;

            Console.Write("Enter radius circle: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter the length of the side of the triangle: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter the length of the triangle height: ");
            h = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();

            Foo(r, a, h, out A, out S);

        }
    }
}
