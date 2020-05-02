using Patterns.Behavioural.Memento.Abstraction;
using System.Collections.Generic;

namespace Patterns.Behavioural.Memento.Implementation
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class Broker
    {
        private LinkedList<IStock> StockHistory { get; set; } = new LinkedList<IStock>();

        private LinkedListNode<IStock> Current { get; set; }

        public void Add(IStock state)
        {
            Current = new LinkedListNode<IStock>(state);
            StockHistory.AddLast(Current);
        }

        public IStock Undo()
            => Get(Current.Previous);

        public IStock Redo()
            => Get(Current.Next);

        private IStock Get(LinkedListNode<IStock> node)
        {
            var state = StockHistory.FindLast(node.Value);
            Current = state;

            return state.Value;
        }
    }
}
