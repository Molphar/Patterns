using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryMethod
{
    class Necromancer
    {
        public List<IRaiseUndead> Skills { get; }

        public Necromancer()
        {
            Skills = new List<IRaiseUndead>();
        }

        public Necromancer(params IRaiseUndead[] skills)
        {
            Skills = new List<IRaiseUndead>(skills);
        }


    }
}
