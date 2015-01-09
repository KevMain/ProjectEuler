using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3Or5
{
    public class Multiplier
    {
        private readonly long _number;

        public Multiplier(long number)
        {
            _number = number;
        }

        public long GetNumber()
        {
            return _number;
        }
    }
}
