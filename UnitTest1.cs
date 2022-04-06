using System;
using Xunit;

namespace MyFirstUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassTestAdd()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailTestAdd()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void PassTestSubtract()
        {
            Assert.Equal(4, Subtract(8, 4));
        }

        [Fact]
        public void FailTestSubtract()
        {
            Assert.Equal(4, Subtract(8, 4));
        }

        int Subtract(int x, int y)
        {
            return x - y;
        }

        [Fact]
        public void PassTestMultiply()
        {
            Assert.Equal(4, Multiply(2, 2));
        }

        [Fact]
        public void FailTestMultiply()
        {
            Assert.Equal(5, Multiply(2, 2));
        }

        int Multiply(int x, int y)
        {
            return x * y;
        }

        int Divide(int x, int y)
        {
            return x / y;
        }

        [Fact]
        public void PassTestDivide()
        {
            Assert.Equal(2, Divide(4, 2));
        }

        [Fact]
        public void FailTestDivide()
        {
            Assert.Equal(3, Divide(4, 2));
        }
    }
}
