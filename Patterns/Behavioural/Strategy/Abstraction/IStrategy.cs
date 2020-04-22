using System.Collections.Generic;

namespace Patterns.Behavioural.Strategy.Abstraction
{
    public interface IStrategy
    {
        IEnumerable<int> Sort(IEnumerable<int> source);
    }
}
