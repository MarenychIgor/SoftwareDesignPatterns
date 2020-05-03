namespace Patterns.Creational.Singleton.Implementation
{
    /// <summary>
    /// The 'Singleton' class
    /// Defines an Instance operation that lets clients access its unique instance.
    /// Responsible for creating and maintaining its own unique instance.
    /// </summary>
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object _lockObject = new object();

        private ThreadSafeSingleton() { }

        public static ThreadSafeSingleton GetInstance()
        {
            if(_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                        _instance = new ThreadSafeSingleton();
                }
            }

            return _instance;
        }
    }
}
