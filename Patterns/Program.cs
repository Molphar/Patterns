﻿using Patterns.Strategy;
using Patterns.FactoryMethod;
using Patterns.Builder;
using Patterns.Builder.ConcreteBuilder;
using Patterns.TemplateMethod;
using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            //Hero heroAxe = new Hero(new Axe(damage: 90));
            //Hero heroBlade = new Hero(new Blade(damage: 95));

            //int monsterDef = 75;

            //Console.WriteLine($"Axe: {heroAxe.Attack(monsterDef)}");
            //Console.WriteLine($"Axe: {heroBlade.Attack(monsterDef)}");
            #endregion

            #region Factory Method
            //Necromancer necromancer = new Necromancer();
            //Undead undead = necromancer.RaiseUndead<Sceleton>();
            #endregion

            #region TamplateMethod

            ArmorSmith aSmith = new ArmorSmith();
            WeaponSmith wSmith = new WeaponSmith();

            aSmith.ForgeGear();
            Console.WriteLine("Armor Ready!!!\n");

            wSmith.ForgeGear();
            Console.WriteLine("Weapon Ready!!!\n");

            #endregion

            #region Builder

            //string player = "Me";
            //string target = "Foe";
            //string world = "sand";

            //SpellDirector lol = new SpellDirector();
            //SpellBuffBuilder builder = new SpellBuffBuilder(player, target, world);
            //lol.Builder = builder;
            //lol.BuildSpell();
            //builder.GetSpell();

            #endregion

            Console.ReadLine();
        }
    }
}
