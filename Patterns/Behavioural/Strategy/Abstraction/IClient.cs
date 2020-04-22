using System.Collections.Generic;

namespace Patterns.Behavioural.Strategy.Abstraction
{
    public interface IClient
    {
        void SetStrategy(IStrategy strategy);

        IEnumerable<int> Sort(IEnumerable<int> source);
    }
}
