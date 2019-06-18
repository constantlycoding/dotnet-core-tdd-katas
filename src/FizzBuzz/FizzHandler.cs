using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzHandler : NumberHandlerBase
    {
        public override string Handle(Number number)
        {
            if (number.IsDivisibleBy3)
            {
                return "Fizz";
            }
            return NextHandler.Handle(number);
        }
    }
}
