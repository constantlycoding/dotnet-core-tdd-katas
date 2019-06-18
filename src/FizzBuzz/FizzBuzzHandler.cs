using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzHandler : NumberHandlerBase
    {
        public override string Handle(Number number)
        {
            if (number.IsDivisibleBy3And5)
            {
                return "FizzBuzz";
            }
            return NextHandler.Handle(number);
        }
    }
}
