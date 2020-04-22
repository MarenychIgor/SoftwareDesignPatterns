using Examples.Behavioural;
using Examples.Creational;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Behavioural examples
            var strategy = new StrategyExample();
            strategy.RunExample();

            // Creational examples
            var singleton = new SingletonExample();
            singleton.RunExample();   
        }
    }
}
