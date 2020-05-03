using Patterns.Creational.Singleton.Implementation;

namespace Examples.Creational
{
    public class SingletonExample
    {
        public void RunExample()
        {
            var singleton = Singleton.GetInstance();
            var threadSafeSingleton = ThreadSafeSingleton.GetInstance();
            var lazySingleton = LazySingleton.GetInstance();
        }
    }
}
