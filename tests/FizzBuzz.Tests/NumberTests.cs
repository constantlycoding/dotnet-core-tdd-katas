using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class NumberTests
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(15)]
        public void IsDivisibleBy5_MultipleOf5_ReturnsTrue(int value)
        {
            var number = new Number(value);
            Assert.True(number.IsDivisibleBy5);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(12)]
        public void IsDivisibleBy5_NotMultipleOf5_ReturnsFalse(int value)
        {
            var number = new Number(value);
            Assert.False(number.IsDivisibleBy5);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void IsDivisibleBy3_MultipleOf3_ReturnsTrue(int value)
        {
            var number = new Number(value);
            Assert.True(number.IsDivisibleBy3);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(8)]
        public void IsDivisibleBy3_NotMultipleOf3_ReturnsFalse(int value)
        {
            var number = new Number(value);
            Assert.False(number.IsDivisibleBy3);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void IsDivisibleBy3And5_MultipleOf15_ReturnsTrue(int value)
        {
            var number = new Number(value);
            Assert.True(number.IsDivisibleBy3And5);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(23)]
        [InlineData(34)]
        public void IsDivisibleBy3And5_NotMultipleOf15_ReturnsFalse(int value)
        {
            var number = new Number(value);
            Assert.False(number.IsDivisibleBy3And5);
        }
    }
}
