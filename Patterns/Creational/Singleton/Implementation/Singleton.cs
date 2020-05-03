namespace Patterns.Creational.Singleton.Implementation
{
    /// <summary>
    /// The 'Singleton' class
    /// Defines an Instance operation that lets clients access its unique instance.
    /// Responsible for creating and maintaining its own unique instance.
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if(_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }
}
