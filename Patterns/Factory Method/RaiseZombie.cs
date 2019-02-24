using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryMethod
{
    class RaiseZombie : IRaiseUndead
    {
        public Undead Raise()
        {
            return new Zombie();
        }
    }
}
