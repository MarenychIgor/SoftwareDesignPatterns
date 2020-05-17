using Patterns.Behavioural.Memento.Abstraction;
using Patterns.Behavioural.Memento.Implementation;
using System;

namespace Examples.Behavioural
{
    public class MementoExample
    {
        private const string _stockName = "AAPL";

        private readonly StockExchange _exchange = new StockExchange();
        private IStock _stock;

        public void RunExample()
        {
            SaveState(price: 0.6161M, new DateTime(1981, month: 1, day: 2));
            SaveState(price: 1.2407M, new DateTime(2001, month: 9, day: 10));
            SaveState(price: 289.07M, new DateTime(2020, month: 5, day: 1));

            Undo();
            Undo();

            Redo();
            Redo();
        }

        private void SaveState(decimal price, DateTime date)
        {            
            _exchange.SaveState(_stockName, price, date);
            var state = _exchange.GetState();

            _exchange.Add(state);
        }

        private void Undo()
        {
            var state = _exchange.Undo();

            _exchange.RestoreState(state);
            _stock = _exchange.GetState();
        }

        private void Redo()
        {
            var state = _exchange.Redo();

            _exchange.RestoreState(state);
            _stock = _exchange.GetState();
        }
    }
}
