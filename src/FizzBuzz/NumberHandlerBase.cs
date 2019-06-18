using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public abstract class NumberHandlerBase : INumberHandler
    {
        protected INumberHandler NextHandler;

        public abstract string Handle(Number number);

        public void SetSuccessor(INumberHandler handler)
        {
            NextHandler = handler;
        }
    }
}
