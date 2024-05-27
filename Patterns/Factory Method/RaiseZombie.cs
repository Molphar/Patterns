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
