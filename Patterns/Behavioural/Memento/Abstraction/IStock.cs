using System;

namespace Patterns.Behavioural.Memento.Abstraction
{
    /// <summary>
    /// Interface for 'Memento' class.
    /// </summary>
    public interface IStock
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
