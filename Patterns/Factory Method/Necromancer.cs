namespace Patterns.FactoryMethod
{
    class Necromancer
    {
        public Undead RaiseUndead<T>() where T : Undead
        {
            T unded = default;
            IRaiseUndead undeadFactory;

            switch (unded)
            {
                case Sceleton _:
                    undeadFactory = new RaiseSceleton();
                    break;
                case Zombie _:
                    undeadFactory = new RaiseZombie();
                    break;
                default:
                    undeadFactory = null;
                    break;
            }

            return undeadFactory.Raise();
        }
    }
}
