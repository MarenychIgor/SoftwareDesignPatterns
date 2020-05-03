using Patterns.Behavioural.Strategy.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioural.Strategy.Implementation
{
    /// <summary>
    /// The 'ConcreteStrategy' class.
    /// Implements the insertion sort algorithm using the <see cref="IStrategy"/> interface.
    /// </summary>
    public class InsertionSort : IStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            var arr = source.ToArray();

            for (var i = 1; i < arr.Length; i++)
            {
                var value = arr[i];
                var j = i - 1;

                while (j >= 0 && arr[j] > value)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = value;
            }

            return arr;
        }
    }
}
