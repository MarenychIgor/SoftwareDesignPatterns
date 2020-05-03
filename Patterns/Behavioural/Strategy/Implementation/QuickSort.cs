using Patterns.Behavioural.Strategy.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioural.Strategy.Implementation
{
    /// <summary>
    /// The 'ConcreteStrategy' class.
    /// Implements the quick sort algorithm using the <see cref="IStrategy"/> interface.
    /// </summary>
    public class QuickSort : IStrategy
    {
        public IEnumerable<int> Sort(IEnumerable<int> source)
        {
            var arr = source.ToArray();
            Sort(arr, default, arr.Length - 1);

            return arr;
        }

        private void Sort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            var value = array[left];
            var i = left;
            var j = right;

            while (i < j)
            {
                while (i < j && array[j] >= value)
                    j--;

                array[i] = array[j];

                while (i < j && array[i] <= value)
                    i++;

                array[j] = array[i];
            }

            array[i] = value;
            Sort(array, left, i - 1);
            Sort(array, i + 1, right);
        }
    }
}
