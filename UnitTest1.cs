using System;
using Xunit;
using Calc;

namespace MyFirstUnitTests
{
    public class UnitTest1
    {
         
        [Fact]
        public void PassTestAdd()
        {
            Calculator calc = new ();

            int answer = calc.Add(2, 2);

            Assert.Equal(4, answer);
            //Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailTestAdd()
        {
            Calculator calc = new();
            Assert.Equal(5, calc.Add(2, 2));
        }

        [Fact]
        public void PassTestSubtract()
        {
            //Calculator calc = new Calculator(); is the same as the line below \/
            Calculator calc = new();
            Assert.Equal(4, calc.Subtract(8, 4));
        }

        [Fact]
        public void FailTestSubtract()
        {
            Calculator calc = new ();
            Assert.Equal(5, calc.Subtract(8, 4));
        }

        [Fact]
        public void PassTestMultiply()
        {
            Calculator calc = new ();
            Assert.Equal(4, calc.Multiply(2, 2));
        }

        [Fact]
        public void FailTestMultiply()
        {
            Calculator calc = new ();
            Assert.Equal(5, calc.Multiply(2, 2));
        }

        [Fact]
        public void PassTestDivide()
        {
            Calculator calc = new ();
            Assert.Equal(2, calc.Divide(4, 2));
        }

        [Fact]
        public void FailTestDivide()
        {
            Calculator calc = new ();
            Assert.Equal(3, calc.Divide(4, 2));
        }

        [Fact]
        public void PassTestPower()
        {
            Calculator calc = new ();
            Assert.Equal(4, calc.Power(2, 2));
        }

        [Fact]
        public void FailTestPower()
        {
            Calculator calc = new ();
            Assert.Equal(3, calc.Power(2, 2));
        }
    }
}
