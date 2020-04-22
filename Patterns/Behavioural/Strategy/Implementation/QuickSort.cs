using Patterns.Behavioural.Strategy.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Behavioural.Strategy.Implementation
{
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

            var i = left;
            var j = right;

            while (i < j)
            {
                while (i < j && array[j] >= array[left])
                    j--;

                array[i] = array[j];

                while (i < j && array[i] <= array[left])
                    i++;

                array[j] = array[i];
            }

            array[i] = array[left];
            Sort(array, left, i - 1);
            Sort(array, i + 1, right);
        }
    }
}
