using Patterns.Behavioural.Memento.Abstraction;
using System.Collections.Generic;

namespace Patterns.Behavioural.Memento.Implementation
{
    /// <summary>
    /// The 'Caretaker' class.
    /// Is responsible for the memento's safekeeping.
    /// Never operates on or examines the contents of a <see cref="Stock"/>.
    /// </summary>
    public class Broker
    {
        public LinkedList<IStock> StockHistory { get; set; } = new LinkedList<IStock>();
    }
}
