using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    class Axe : IWeapon
    {
        public int Damage { get; private set; }

        public Axe(int damage)
        {
            Damage = damage;
        }

        public float Attack(int def)
        {
            return (Damage * def / 90);
        }
    }
}
