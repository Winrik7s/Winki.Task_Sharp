namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Foo(float a, float b, float c, out float resultC, out float resultT)
        {
            resultC = (float)(3.14 * (a * a));
            resultT = a * c / 2;

            if (resultC > resultT)
            {
                Console.WriteLine("The triangle fit in a circle!");
            }
            else
            {
                Console.WriteLine("The circle fit in the triangle!");
            }
        }

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
