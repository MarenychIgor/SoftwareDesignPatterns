using Patterns.Behavioural.Strategy.Abstraction;
using System.Collections.Generic;

namespace Patterns.Behavioural.Strategy
{
    public class Client : IClient
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
            => _strategy = strategy;

        public IEnumerable<int> Sort(IEnumerable<int> source)
            => _strategy.Sort(source);
    }
}
