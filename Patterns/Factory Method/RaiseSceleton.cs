using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryMethod
{
    class RaiseSceleton : IRaiseUndead
    {
        public Undead Raise()
        {
            return new Sceleton();
        }
    }
}
