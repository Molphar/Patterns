namespace Patterns.Builder
{
    public class SpellDirector
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildSpell()
        {
            _builder.BuildRoles();
            _builder.BuildAttribute();
            _builder.BuildTime();
            _builder.BuildEffects();
        }
    }
}
