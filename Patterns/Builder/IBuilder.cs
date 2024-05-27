namespace Patterns.Builder
{
    public interface IBuilder
    {
        // targets and casters and area
        void BuildRoles();

        //what attribute
        void BuildAttribute();

        // time management
        void BuildTime();

        //set effect and dmaage and element and amplification
        void BuildEffects();

        Spell GetSpell();
    }
}
