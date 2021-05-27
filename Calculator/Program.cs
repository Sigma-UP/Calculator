using System;
namespace CalculatorMain
{
    public static class Calculator
    {
        public static double Division(double arg_x, double arg_y)
        {
            return arg_x/arg_y;
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
            int a = 9, b = 2;
            Console.WriteLine($"D = {Calculator.Division(a, b)}");
            Console.WriteLine($"M = {Calculator.Multiplication(a, b)}");
            Console.WriteLine($"A = {Calculator.Addiction(a, b)}");
            Console.WriteLine($"S = {Calculator.Substraction(a, b)}");
        }
    }
}
