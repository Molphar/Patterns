using Patterns.Strategy;
using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            Hero heroAxe = new Hero(new Axe(damage: 90));
            Hero heroBlade = new Hero(new Blade(damage: 95));

            int monsterDef = 75;

            Console.WriteLine($"Axe: {heroAxe.Attack(monsterDef)}");
            Console.WriteLine($"Axe: {heroBlade.Attack(monsterDef)}");
            #endregion




            Console.ReadLine();
        }
    }
}
