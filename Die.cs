using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLVP_Week5_DiesAndDiecups
{
    internal class Die
    {
        // Private fields naming according to https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
        private static Random _rand;
        private int _value;

        public Die()
        {
            _rand = new Random();
            _value = _rand.Next(1, 7);
        }

        public void Roll()
        {
            _value = _rand.Next(1, 7);
        }

        public int GetValue()
        {
            return _value;
        }

    }


}
