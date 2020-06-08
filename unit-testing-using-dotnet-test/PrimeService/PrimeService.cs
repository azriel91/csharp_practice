using System;
using System.Collections.Generic;
using System.Linq;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(Int32 candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            if (candidate == 2)
            {
                return true;
            }
            if (candidate % 2 == 0)
            {
                return false;
            }

            return Enumerable
                .Range(3, candidate - 3)
                .Where(n => n % 2 == 1)
                .All(n => candidate % n != 0);
        }
    }
}
