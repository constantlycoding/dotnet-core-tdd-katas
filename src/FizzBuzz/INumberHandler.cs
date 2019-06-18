using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public interface INumberHandler
    {
        void SetSuccessor(INumberHandler handler);

        string Handle(Number number);
    }
}
