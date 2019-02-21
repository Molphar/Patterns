using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Factory_Method
{
    class RaiseZombie : RaiseUndead
    {
        public override Undead Raise()
        {
            return new Zombie();
        }
    }
}
