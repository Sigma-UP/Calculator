using System;
namespace CalculatorMain
{

    public static class Calculator
    {
        public static double Division(double arg_x, double arg_y)
        {
            return arg_x / arg_y;
        }
        public static double Multiplication(double arg_x, double arg_y)
        {
            return arg_x * arg_y;
        }
        public static double Addiction(double arg_x, double arg_y)
        {
            return arg_x + arg_y;
        }
        public static double Substraction(double arg_x, double arg_y)
        {
            return arg_x - arg_y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, num;
            while (true)
            {
                Console.Write("Enter a: ");
                if (Double.TryParse(Console.ReadLine(), out num))
                {
                    a = num;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter b: ");
                if (Double.TryParse(Console.ReadLine(), out num))
                {
                    b = num;
                    break;
                }
            }

            Console.Write($"Choose operation:\n1. {a} + {b}\n2. {a} - {b}\n3. {a} * {b}\n4. {a} / {b}\nYour choice is ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {Calculator.Addiction(a, b)}");
                    break;
                case 2:
                    Console.WriteLine($"{a} + {b} = {Calculator.Substraction(a, b)}");
                    break;
                case 3:
                    Console.WriteLine($"{a} + {b} = {Calculator.Multiplication(a, b)}");
                    break;
                case 4:
                    Console.WriteLine($"{a} / {b} = {Calculator.Division(a, b)}");
                    break;
                default:
                    break;
            }
        }
    }
}