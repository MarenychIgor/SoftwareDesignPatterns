using Patterns.Behavioural.Memento.Abstraction;
using System;

namespace Patterns.Behavioural.Memento.Implementation
{
    /// <summary>
    /// The 'Originator' class
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
