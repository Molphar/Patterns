namespace Patterns.Builder.ConcreteBuilder
{
    abstract public class SpellBuilder : IBuilder
    {
        protected string player;
        protected string target;
        protected string worldParams;

        public SpellBuilder(string player, string target, string worldParams)
        {
            Reset();
            this.player = player;
            this.target = target;
            this.worldParams = worldParams;
        }

        public abstract void Reset();

        public abstract void BuildRoles();

        public abstract void BuildAttribute();

        public abstract void BuildTime();

        public abstract void BuildEffects();

        public abstract Spell GetSpell();
    }
}
