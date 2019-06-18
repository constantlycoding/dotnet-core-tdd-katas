using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class NumberHandlerTests
    {
        [Fact]
        public void FizzHandler_MultipleOf3_ReturnsFizz()
        {
            var number = new Number(3);
            var handler = new FizzHandler();
            Assert.Equal("Fizz", handler.Handle(number));
        }

        [Fact]
        public void BuzzHandler_MultipleOf5_ReturnsBuzz()
        {
            var number = new Number(5);
            var handler = new BuzzHandler();
            Assert.Equal("Buzz", handler.Handle(number));
        }

        [Fact]
        public void FizzBuzzHandler_MultipleOf15_ReturnsFizzBuzz()
        {
            var number = new Number(15);
            var handler = new FizzBuzzHandler();
            Assert.Equal("FizzBuzz", handler.Handle(number));
        }

        [Fact]
        public void FizzBuzzChain_MultipleOf3_ReturnsFizzBuzz()
        {
            var number = new Number(3);
            var fizzBuzzHandler = new FizzBuzzHandler();
            var fizzHandler = new FizzHandler();
            var buzzHandler = new BuzzHandler();
            fizzBuzzHandler.SetSuccessor(fizzHandler);
            fizzHandler.SetSuccessor(buzzHandler);
            Assert.Equal("Fizz", fizzBuzzHandler.Handle(number));
        }
    }
}
