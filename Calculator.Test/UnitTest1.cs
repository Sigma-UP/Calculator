using System;
using Xunit;
namespace CalculatorMain.Test
{
    public class Calculations
    {
        double x = 6, y = 4;
        [Fact]
        public void Division()
        {
            Assert.Equal(Calculator.Division(x, y), x/y);
            Assert.Equal(Calculator.Division(y, x), y/x);
            Assert.Equal(Calculator.Division(x, x), 1);
            Assert.Equal(Calculator.Division(x, 1), x);
            // Assert.Equal(CalculatorCL.Division(2, 0), ); figure out divide by zero asap
        }
        public void Multiplication()
        {
            Assert.Equal(Calculator.Multiplication(x, y), x*y);
            Assert.Equal(Calculator.Multiplication(x, x), x*x);
            Assert.Equal(Calculator.Multiplication(x, 1), x);
            Assert.Equal(Calculator.Multiplication(x, 0.5), x / 2);
            Assert.Equal(Calculator.Multiplication(x, 0), 0);
        }
        public void Addition()
        {
            Assert.Equal(Calculator.Addiction(x, y), x + y);
        }
        public void Substraction()
        {
            Assert.Equal(Calculator.Substraction(x, y), x - y);
            Assert.Equal(Calculator.Subscriptions(y, x), y - x);
        }
    }
}
