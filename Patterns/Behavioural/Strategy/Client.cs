using Patterns.Behavioural.Strategy.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioural.Strategy
{
    /// <summary>
    /// The 'Context' class.
    /// Configured with a 'ConcreteStrategy' object.
    /// Maintains a reference to a <see cref="IStrategy"/> object.
    /// May define an interface that lets <see cref="IStrategy"/> access its data.
    /// </summary>
    public class Client
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
            => _strategy = strategy;

        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            return _strategy != null
                ? _strategy.Sort(source)
                : source.OrderBy(x => x);
        }
    }
}
