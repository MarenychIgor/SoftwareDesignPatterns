using Patterns.Behavioural.Strategy;
using Patterns.Behavioural.Strategy.Implementation;
using System;
using System.Linq;

namespace Examples.Behavioural
{
    public class StrategyExample
    {
        public void RunExample()
        {
            var random = new Random(Environment.TickCount);
            var array = Enumerable
                .Repeat<int>(default, 100)
                .Select(x => random.Next(int.MinValue, int.MaxValue))
                .ToList();

            var client = new Client();

            client.SetStrategy(new BubbleSort());
            var bubbleSortedArray = client.Sort(array);

            client.SetStrategy(new QuickSort());
            var quickSortedArray = client.Sort(array);

            client.SetStrategy(new InsertionSort());
            var insertionSortedArray = client.Sort(array);
        }
    }
}
