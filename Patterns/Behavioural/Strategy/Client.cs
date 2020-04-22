using Patterns.Behavioural.Strategy.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioural.Strategy
{
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
