using Patterns.Behavioural.Memento.Abstraction;
using System;

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
    }
}
