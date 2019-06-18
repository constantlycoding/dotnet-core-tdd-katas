using System;

namespace FizzBuzz
{
    public class Number
    {
        int _value;
        public Number(int value)
        {
            _value = value;
        }

        public bool IsDivisibleBy5 => _value % 5 == 0;

        public bool IsDivisibleBy3 => _value % 3 == 0;

        public bool IsDivisibleBy3And5 => _value % 15 == 0;
    }
}
