using System.Collections.Generic;

namespace Patterns.Behavioural.Strategy.Abstraction
{
    /// <summary>
    /// Interface for 'Strategy' class.
    /// Declares an interface common to all supported algorithms.
    /// <see cref="Client"/> uses this interface to call the algorithm defined by a 'ConcreteStrategy'.
    /// </summary>
    public interface IStrategy
    {
        IEnumerable<int> Sort(IEnumerable<int> source);
    }
}
