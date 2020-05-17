using Examples.Behavioural;
using Examples.Creational;
using Examples.Structural;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Behavioural examples
            var strategy = new StrategyExample();
            strategy.RunExample();

            var chain = new ChainOfResponsibilityExample();
            chain.RunExample();

            var memento = new MementoExample();
            memento.RunExample();

            var command = new CommandExample();
            command.RunExample();

            // Creational examples
            var singleton = new SingletonExample();
            singleton.RunExample();

            var builder = new BuilderExample();
            builder.RunExample();

            // Structural examples
            var adapter = new AdapterExample();
            adapter.RunExample();
        }
    }
}
