using System;

namespace Patterns.Creational.Singleton
{
    public class LazySingleton
    {
        private static Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(new LazySingleton());

        private LazySingleton() { }

        public static LazySingleton GetInstance()
            => _instance.Value;
    }
}
