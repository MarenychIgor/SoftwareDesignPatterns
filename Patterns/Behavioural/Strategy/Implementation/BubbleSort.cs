using Patterns.Behavioural.Strategy.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioural.Strategy.Implementation
{
    /// <summary>
    /// The 'ConcreteStrategy' class.
    /// Implements the bubble sort algorithm using the <see cref="IStrategy"/> interface.
    /// </summary>
    public class BubbleSort : IStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            var array = source.ToArray();

            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
