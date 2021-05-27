using System;
using Xunit;
namespace CalculatorMain.Test
{
    public class Calculations
    {
        const double x = 6, y = 4;
        [Fact]
        public void Division()
        {
            Assert.Equal(1.5, Calculator.Division(x, y));
            Assert.Equal(y / x, Calculator.Division(y, x));
            Assert.Equal(1, Calculator.Division(x, x));
            Assert.Equal(6, Calculator.Division(x, 1));
            // Assert.Equal(CalculatorCL.Division(2, 0), ); figure out divide by zero asap
        }
        [Fact]
        public void Multiplication()
        {
            Assert.Equal(24,    Calculator.Multiplication(x, y));
            Assert.Equal(36,    Calculator.Multiplication(x, x));
            Assert.Equal(6,      Calculator.Multiplication(x, 1));
            Assert.Equal(3,  Calculator.Multiplication(x, 0.5));
            Assert.Equal(0,      Calculator.Multiplication(x, 0));
        }
        [Fact]
        public void Addition()
        {
            Assert.Equal(10, Calculator.Addiction(x, y));
        }
        [Fact]
        public void Substraction()
        {
            Assert.Equal(2, Calculator.Substraction(x, y));
            Assert.Equal(-2, Calculator.Substraction(y, x));
        }
    }
}
