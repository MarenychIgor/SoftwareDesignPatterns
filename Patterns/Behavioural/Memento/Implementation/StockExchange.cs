using Patterns.Behavioural.Memento.Abstraction;
using System;
using System.Collections.Generic;

namespace Patterns.Behavioural.Memento.Implementation
{
    /// <summary>
    /// The 'Originator' class.
    /// Creates a <see cref="Stock"/> containing a snapshot of its current internal state.
    /// Uses the <see cref="Stock"/> to restore its internal state.
    /// </summary>
    public class StockExchange
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        private readonly Broker _broker = new Broker();
        private LinkedListNode<IStock> _current { get; set; }

        public IStock GetState()
            => new Stock(Name, Price, Date);

        public void SaveState(string name, decimal price, DateTime date)
        {
            Name = name;
            Price = price;
            Date = date;
        }

        public void RestoreState(IStock stock)
        {
            Name = stock.Name;
            Price = stock.Price;
            Date = stock.Date;
        }

        public void Add(IStock state)
        {
            _current = new LinkedListNode<IStock>(state);
            _broker.StockHistory.AddLast(_current);
        }

        public IStock Undo()
            => Get(_current.Previous);

        public IStock Redo()
            => Get(_current.Next);

        private IStock Get(LinkedListNode<IStock> node)
        {
            var state = _broker.StockHistory.FindLast(node.Value);
            _current = state;

            return state.Value;
        }
    }
}
