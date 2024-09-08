using System;
using System.Linq;
using Xunit;

namespace UnitTestProject1
{
    public class ProgramTests
    {
        [Fact]
        public void CountEvenPositive_EmptyArray_ReturnsZero()
        {
            double[] arr = new double[0];
            int result = Program.CountEvenPositive(arr);
            Assert.Equal(0, result);
        }

        [Fact]
        public void CountEvenPositive_OneEvenPositiveElement_ReturnsOne()
        {
            double[] arr = { 4.0 };
            int result = Program.CountEvenPositive(arr);
            Assert.Equal(1, result);
        }

        [Fact]
        public void CountEvenPositive_MultipleEvenPositiveElements_ReturnsCorrectCount()
        {
            double[] arr = { 2.0, 4.0, 6.0, 8.0 };
            int result = Program.CountEvenPositive(arr);
            Assert.Equal(4, result);
        }

        [Fact]
        public void CountEvenPositive_NoEvenPositiveElements_ReturnsZero()
        {
            double[] arr = { 1.5, 3.1, 5.7 };
            int result = Program.CountEvenPositive(arr);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SumInRange_EmptyArray_ReturnsZero()
        {
            double[] arr = new double[0];
            double b = 0.0;
            double d = 10.0;
            double result = Program.SumInRange(arr, b, d);
            Assert.Equal(0.0, result);
        }

        [Fact]
        public void SumInRange_OneElementInRange_ReturnsElementValue()
        {
            double[] arr = { 5.0 };
            double b = 4.0;
            double d = 6.0;
            double result = Program.SumInRange(arr, b, d);
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void SumInRange_MultipleElementsInRange_ReturnsCorrectSum()
        {
            double[] arr = { 2.0, 4.0, 6.0, 8.0 };
            double b = 3.0;
            double d = 7.0;
            double result = Program.SumInRange(arr, b, d);
            Assert.Equal(10.0, result);
        }

        [Fact]
        public void SumInRange_NoElementsInRange_ReturnsZero()
        {
            double[] arr = { 2.0, 4.0, 6.0, 8.0 };
            double b = 1.0;
            double d = 2.0;
            double result = Program.SumInRange(arr, b, d);
            Assert.Equal(2.0, result);
        }
    }
}
