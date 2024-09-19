namespace Winki.Task_Sharp
{
    public class Program
    {
        static void Foo(float a, float b, out float resultC, out float resultS)
        {
            resultC = (float)(3.14 * (a * a));
            resultS = (float)(b * b);

            if (resultC > resultS)
            {
                Console.WriteLine("The square fit in a circle!");
            }
            else
            {
                Console.WriteLine("The circle fit in the square!");
            }
        }

        static void Main(string[] args)
        {
            float r;
            float a;

            float A;
            float S;

            Console.Write("Enter radius circle: ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter side square: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();

            Foo(r, a, out A, out S);

        }
    }
}
