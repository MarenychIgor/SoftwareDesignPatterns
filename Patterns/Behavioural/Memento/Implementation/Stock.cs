using Patterns.Behavioural.Memento.Abstraction;
using System;

namespace Patterns.Behavioural.Memento.Implementation
{
    /// <summary>
    /// The 'Memento' class.
    /// Stores internal state of the <see cref="StockExchange"/> object.
    /// </summary>
    public class Stock : IStock
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public Stock(string name, decimal price, DateTime date)
        {
            Name = name;
            Price = price;
            Date = date;
        }
    }
}
