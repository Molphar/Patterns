using System;

namespace Patterns.Builder.ConcreteBuilder
{
    public class SpellBuffBuilder : SpellBuilder
    {
        private Spell _spell = new Spell();

        public SpellBuffBuilder(string player, string target, string worldParams) 
            : base(player, target, worldParams)
        {
            _spell = new Spell();
        }

        public override void BuildRoles()
        {
            _spell.Player = player;
            _spell.Target = target;
            if (!string.IsNullOrEmpty(worldParams))
            {
                _spell.EffectArea = "good!";
            }
        }

        public override void BuildAttribute()
        {
            _spell.Attribut = "lolol";
        }

        public override void BuildEffects()
        {
            _spell.AdditionalEffects = "DOT";
        }

        public override void BuildTime()
        {
            _spell.Duration = 60;
            _spell.Casting = 60;
        }

        public override Spell GetSpell()
        {
            return _spell;
        }

        public override void Reset()
        {
            _spell = new Spell();
        }
    }
}
