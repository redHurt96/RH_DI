namespace RH.Utilities.ServiceLocator
{
    public abstract class Singleton<TSelf> where TSelf : Singleton<TSelf>
    {
        protected static TSelf Instance { get; private set; }

        protected Singleton() => 
            Instance ??= this as TSelf;
    }
}