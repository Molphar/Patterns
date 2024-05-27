namespace Patterns.FactoryMethod
{
    class RaiseSceleton : IRaiseUndead
    {
        public Undead Raise()
        {
            return new Sceleton();
        }
    }
}
