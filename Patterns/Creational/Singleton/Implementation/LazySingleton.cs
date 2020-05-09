using System;

namespace Patterns.Creational.Singleton.Implementation
{
    /// <summary>
    /// The 'Singleton' class
    /// Defines an Instance operation that lets clients access its unique instance.
    /// Responsible for creating and maintaining its own unique instance.
    /// </summary>
    public sealed class LazySingleton
    {
        private static Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(new LazySingleton());

        private LazySingleton() { }

        public static LazySingleton GetInstance()
            => _instance.Value;
    }
}
