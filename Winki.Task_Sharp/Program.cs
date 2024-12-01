using System.Linq;

namespace Winki.Task_Sharp
{
    public class Program
    {
        static double Add(double a, double b) 
        {
            return a + b;
        }

        static double Sub(double a, double b)
        {
            return a - b;
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }

        static double Div(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            double result;

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Select an arithmetic operation (+, -, *, /): ");
            string? operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = Add(num1, num2);
                break;

                case "-":
                    result = Add(num1, num2);
                break;

                case "*":
                    result = Add(num1, num2);
                break;

                case "/":
                    result = Add(num1, num2);
                break;

                default:
                    Console.WriteLine("Error! Enter the operation from the presented list.");
                break;
            }
        }
    }
}