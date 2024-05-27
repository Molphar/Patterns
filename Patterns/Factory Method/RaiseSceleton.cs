using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Factory_Method
{
    class RaiseSceleton : RaiseUndead
    {
        public override Undead Raise()
        {
            return new Sceleton();
        }
    }
}
