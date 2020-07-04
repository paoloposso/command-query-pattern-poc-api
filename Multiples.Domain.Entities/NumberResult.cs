using System;

namespace Multiples.Domain.Entities
{
    public class NumberResult
    {
        public string Number { get; private set; }
        public bool IsMultiple { get; private set; }

        public NumberResult(string number, bool isMultiple) 
        {
            Number = number;
            IsMultiple = isMultiple;
        }
    }
}
