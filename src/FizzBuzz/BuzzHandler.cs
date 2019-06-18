using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class BuzzHandler : NumberHandlerBase
    {
        public override string Handle(Number number)
        {
            if (number.IsDivisibleBy5)
            {
                return "Buzz";
            }
            return NextHandler.Handle(number);
        }
    }
}
